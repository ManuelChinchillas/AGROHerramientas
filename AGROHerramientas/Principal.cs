using AGROHerramientas.Inventarios;
using AGROHerramientas.Reportes;
using AGROHerramientas.Tableros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGROHerramientas
{
    public partial class Principal : Form
    {
        private bool isCollapse = false;
        private int Altura = 0;
        private Panel Panel = null;
        public Principal()
        {
            InitializeComponent();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlBarra_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pnlBarra_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void AbrirForma(object forma)
        {
            try
            {
                pnlIndicador.Visible = true;
                if (this.pnlPrincipal.Controls.Count > 0)
                    this.pnlPrincipal.Controls.RemoveAt(0);
                Form fn = forma as Form;
                fn.TopLevel = false;
                fn.Dock = DockStyle.Fill;
                this.pnlPrincipal.Controls.Add(fn);
                fn.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Principal", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            
        }
        private void btnInventarios_Click(object sender, EventArgs e)
        {
            if (pnlInventarios.Height == 150)
            {
                Panel = pnlInventarios;
                Altura = 40;
                isCollapse = false;
                timer1.Start();
            }
            else
            {
                Panel = pnlInventarios;
                Altura = 150;
                isCollapse = true;
                timer1.Start();
            }

            ResetIndicadores();
            pnlIndicador.Visible = true;
        }

        private void btnInventarios_MouseEnter(object sender, EventArgs e)
        {
            btnInventarios.ForeColor = Color.White;
        }

        private void btnInventarios_MouseLeave(object sender, EventArgs e)
        {
            btnInventarios.ForeColor = Color.FromArgb(109,89,89);
        }

        private void btnInvEntregaMercancia_MouseEnter(object sender, EventArgs e)
        {
            pInvEntregaMercancia.BackColor = Color.FromArgb(89,89,89);
            btnInvEntregaMercancia.ForeColor = Color.White;
        }

        private void btnInvEntregaMercancia_MouseLeave(object sender, EventArgs e)
        {
            pInvEntregaMercancia.BackColor = Color.FromArgb(171,235,210);
            btnInvEntregaMercancia.ForeColor = Color.FromArgb(109, 89, 89);
        }

        private void btnInvEntregaMercancia_Click(object sender, EventArgs e)
        {
            ResetIndicadores();
            pnlIndicador.Visible = true;
            pnlIndicadorInvEntregaMercancia.Visible = true;
            Lugar l = new Lugar();
            if (l.ShowDialog() == DialogResult.OK)
            {
                InvEntregaMercancia ie = new InvEntregaMercancia();
                ie.Lugar = l.LugarIndicado;
                AbrirForma(ie);
            }
        }

        private void ResetIndicadores()
        {
            pnlIndicador.Visible = false;
            pnlIndicadorInvEntregaMercancia.Visible = false;
            pnlIndicadorInvPendienteEntrega.Visible = false;
            pnlIndicadorInvValeEntrega.Visible = false;
            pnlIndicadorReportes.Visible = false;
            pnlIndicadorRepPendienteEntrega.Visible = false;
            pnlIndicadorTableroCierre.Visible = false;
            pnlIndicadorTCTableroDeCierre.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isCollapse)
            {
                Panel.Height += 10;
                if(Panel.Height == Altura)
                {
                    timer1.Stop();
                }
            }
            else
            {
                Panel.Height -= 10;
                if (Panel.Height == Altura)
                {
                    timer1.Stop();
                }
            }
        }

        private void btnInvPendienteEntrega_Click(object sender, EventArgs e)
        {
            ResetIndicadores();
            pnlIndicador.Visible = true;
            pnlIndicadorInvPendienteEntrega.Visible = true;
            PendienteDeEntrega pe = new PendienteDeEntrega();
            AbrirForma(pe);
        }

        private void btnInvPendienteEntrega_MouseLeave(object sender, EventArgs e)
        {
            pbInvPendienteEntrega.BackColor = Color.FromArgb(171, 235, 210);
            btnInvPendienteEntrega.ForeColor = Color.FromArgb(109, 89, 89);
        }

        private void btnInvPendienteEntrega_MouseEnter(object sender, EventArgs e)
        {
            pbInvPendienteEntrega.BackColor = Color.FromArgb(89, 89, 89);
            btnInvPendienteEntrega.ForeColor = Color.White;
        }

        private void btnInvValeEntrega_Click(object sender, EventArgs e)
        {
            ResetIndicadores();
            pnlIndicador.Visible = true;
            pnlIndicadorInvValeEntrega.Visible = true;
            ValeEntrega pe = new ValeEntrega();
            AbrirForma(pe);
        }

        private void btnInvValeEntrega_MouseLeave(object sender, EventArgs e)
        {
            pbValeEntrega.BackColor = Color.FromArgb(171, 235, 210);
            btnInvValeEntrega.ForeColor = Color.FromArgb(109, 89, 89);
        }

        private void btnInvValeEntrega_MouseEnter(object sender, EventArgs e)
        {
            pbValeEntrega.BackColor = Color.FromArgb(89, 89, 89);
            btnInvValeEntrega.ForeColor = Color.White;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            try
            {
                pnlInventarios.Visible = UsuarioIniciado.Permisos.Contains("1.2");
                pnlInvEntregaMercancia.Visible = UsuarioIniciado.Permisos.Contains("1.2.1");
                pnlInvPendienteEntrega.Visible = UsuarioIniciado.Permisos.Contains("1.2.2");
                pnlInvValeEntrega.Visible = UsuarioIniciado.Permisos.Contains("1.2.3");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Principal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRepPendienteEntrega_Click(object sender, EventArgs e)
        {
            ResetIndicadores();
            pnlIndicadorReportes.Visible = true;
            pnlIndicadorRepPendienteEntrega.Visible = true;
            ReportePendientesDeEntrega pe = new ReportePendientesDeEntrega();
            AbrirForma(pe);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (pnlReportes.Height == 150)
            {
                Panel = pnlReportes;
                Altura = 40;
                isCollapse = false;
                timer1.Start();
            }
            else
            {
                Panel = pnlReportes;
                Altura = 150;
                isCollapse = true;
                timer1.Start();
            }

            ResetIndicadores();
            pnlIndicadorReportes.Visible = true;
        }

        private void btnTablero_Click(object sender, EventArgs e)
        {
            if (pnlTableroDeCierre.Height == 150)
            {
                Panel = pnlTableroDeCierre;
                Altura = 40;
                isCollapse = false;
                timer1.Start();
            }
            else
            {
                Panel = pnlTableroDeCierre;
                Altura = 150;
                isCollapse = true;
                timer1.Start();
            }
            ResetIndicadores();
            pnlIndicadorTableroCierre.Visible = true;
        }

        private void btnTCTableroDeCierre_Click(object sender, EventArgs e)
        {
            ResetIndicadores();
            pnlIndicadorTableroCierre.Visible = true;
            pnlIndicadorTCTableroDeCierre.Visible = true;
            TableroCierre tm = new TableroCierre();
            AbrirForma(tm);
        }

        private void btnTCTareas_Click(object sender, EventArgs e)
        {
            ResetIndicadores();
            pnlIndicadorTableroCierre.Visible = true;
            pnlIndicadorTCTareas.Visible = true;
            Tareas tm = new Tareas();
            AbrirForma(tm);
        }
    }
}
