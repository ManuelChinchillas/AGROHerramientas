using Comun.Clases;
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
    public partial class BuscarPendienteEntregaVentas : Form
    {
        public string Mov { get; set; }
        public string MovID { get; set; }
        public string ID { get; set; }
        public string Cliente { get; set; }
        public BuscarPendienteEntregaVentas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string FechaD = null;
                string FechaH = FuncionesComunes.horaFinal(dtpFechaH.Value);
                string Buscar = txtBuscar.Text.Replace('*', '%');
                if (chkRango.Checked)
                {
                    FechaD = FuncionesComunes.horaInicial(dtpFechaD.Value);
                }
                DataTable dt = InvConsultas.BuscarPendienteEntregaVentas(UsuarioIniciado.Almacen, Buscar, FechaD, FechaH);
                cfgVentas.DataSource = dt;
                Formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Buscar Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Mov = "";
                MovID = "";
                ID = "";
                Cliente = "";
                if (cfgVentas.Row <= 0)
                    return;

                Mov = cfgVentas[cfgVentas.Row, "Mov"].ToString();
                MovID = cfgVentas[cfgVentas.Row, "MovID"].ToString();
                ID = cfgVentas[cfgVentas.Row, "ID"].ToString();
                Cliente = cfgVentas[cfgVentas.Row, "Cliente"].ToString();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Buscar Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                btnBuscar_Click(btnBuscar, new EventArgs());
        }

        private void cfgVentas_DoubleClick(object sender, EventArgs e)
        {
            btnAceptar_Click(btnAceptar, new EventArgs());
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Formato()
        {
            cfgVentas.Cols["Mov"].Width = 80;
            cfgVentas.Cols["FechaEmision"].Width = 80;
            cfgVentas.Cols["Cliente"].Width = 80;
            cfgVentas.Cols["Total"].Width = 80;
            cfgVentas.Cols["MovID"].Width = 100;
            cfgVentas.Cols["Nombre"].Width = 270;

            cfgVentas.Cols["FechaEmision"].Caption = "Fecha";

            cfgVentas.Cols["ID"].Visible = false;

            cfgVentas.Cols["Mov"].AllowEditing = false;
            cfgVentas.Cols["FechaEmision"].AllowEditing = false;
            cfgVentas.Cols["Cliente"].AllowEditing = false;
            cfgVentas.Cols["Total"].AllowEditing = false;
            cfgVentas.Cols["MovID"].AllowEditing = false;
            cfgVentas.Cols["Nombre"].AllowEditing = false;

            cfgVentas.Cols["Total"].Format = "C2";
        }

        private void chkRango_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRango.Checked)
                dtpFechaH.Enabled = true;
            else
                dtpFechaH.Enabled = false;
        }
    }
}
