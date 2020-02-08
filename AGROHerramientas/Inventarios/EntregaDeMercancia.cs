using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGROHerramientas.Inventarios
{
    public partial class EntregaDeMercancia : Form
    {
        public string ModuloClave { get; set; }
        public string Modulo { get; set; }
        public string ID { get; set; }
        public string Lugar { get; set; }
        public EntregaDeMercancia()
        {
            InitializeComponent();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void EntregaDeMercancia_Load(object sender, EventArgs e)
        {
            try
            {
                InvConsultas.AgroEntregaInserta(UsuarioIniciado.Estacion, (this.ID), UsuarioIniciado.Usuario);
                DataTable Encabezado = InvConsultas.xpAgroEntregaMov(UsuarioIniciado.Estacion);
                lblID.Text = this.ID;
                lblMovID.Text = Encabezado.Rows[0]["Movimiento"].ToString() + " " + Encabezado.Rows[0]["Folio"].ToString();
                txtSituacion.Text = Encabezado.Rows[0]["Estatus"].ToString();
                cfgOriginal.DataSource = InvConsultas.ActualizarEntregas(0, UsuarioIniciado.Estacion, Lugar, this.Modulo);
                cfgCorrectos.DataSource = InvConsultas.ActualizarEntregas(1, UsuarioIniciado.Estacion, Lugar, this.Modulo);
                cfgIncorrectosCantidad.DataSource = InvConsultas.ActualizarEntregas(3, UsuarioIniciado.Estacion, Lugar, this.Modulo);
                cfgIncorrectos.DataSource = InvConsultas.ActualizarEntregas(4, UsuarioIniciado.Estacion, Lugar, this.Modulo);
                txtCodigoDeBarras.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Entrega de Mercancia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCodigoDeBarras_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode == Keys.Enter)
                {
                    InvConsultas.spAgroEntregaActualiza(UsuarioIniciado.Estacion, txtCodigoDeBarras.Text);
                    cfgOriginal.DataSource = InvConsultas.ActualizarEntregas(0, UsuarioIniciado.Estacion, Lugar, this.Modulo);
                    cfgCorrectos.DataSource = InvConsultas.ActualizarEntregas(1, UsuarioIniciado.Estacion, Lugar, this.Modulo);
                    cfgIncorrectosCantidad.DataSource = InvConsultas.ActualizarEntregas(3, UsuarioIniciado.Estacion, Lugar, this.Modulo);
                    cfgIncorrectos.DataSource = InvConsultas.ActualizarEntregas(4, UsuarioIniciado.Estacion, Lugar, this.Modulo);
                    DataTable dt = InvConsultas.articuloEnCB(txtCodigoDeBarras.Text);
                    if (dt != null || dt.Rows.Count > 0)
                    {
                        lblEscaneado.Text = dt.Rows[0]["Articulo"].ToString();
                        lblEscaneado.Text += " - ";
                        lblEscaneado.Text += dt.Rows[0]["Descripcion"].ToString();
                        foreach(C1.Win.C1FlexGrid.Row r in cfgCorrectos.Rows)
                        {
                            if (r["Articulo"].ToString() == dt.Rows[0]["Articulo"].ToString())
                                lblEscaneado.Text += " - " + r["Cantidad"].ToString();
                        }
                    }
                    txtCodigoDeBarras.Text = "";
                    txtCodigoDeBarras.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Entrega de Mercancia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEntregarTodo_Click(object sender, EventArgs e)
        {
            try
            {
                InvConsultas.EntregarTodo(UsuarioIniciado.Estacion, this.ID, this.Modulo);
                cfgOriginal.DataSource = InvConsultas.ActualizarEntregas(0, UsuarioIniciado.Estacion, Lugar, this.Modulo);
                cfgCorrectos.DataSource = InvConsultas.ActualizarEntregas(1, UsuarioIniciado.Estacion, Lugar, this.Modulo);
                cfgIncorrectosCantidad.DataSource = InvConsultas.ActualizarEntregas(3, UsuarioIniciado.Estacion, Lugar, this.Modulo);
                cfgIncorrectos.DataSource = InvConsultas.ActualizarEntregas(4, UsuarioIniciado.Estacion, Lugar, this.Modulo);
                txtCodigoDeBarras.Text = "";
                txtCodigoDeBarras.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Entrega de Mercancia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                InvConsultas.GuardaHistAgroEntrega(UsuarioIniciado.Estacion, this.ID);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Entrega de Mercancia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pnlBarra_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pnlOriginal.Width = this.Width / 2;
            pnlIncorrectosCntidades.Width = this.Width / 2;
            pnlTop.Height = ((this.Height - 100) - 228);
            lblEscaneado.Width = pnlCorrectosFisicamente.Width;
            lblEscaneado.Left = pnlCorrectosFisicamente.Left;
        }

        private void pnlBarra_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
