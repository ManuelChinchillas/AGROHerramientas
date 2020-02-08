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
    public partial class BuscarPendienteEntrega : Form
    {
        public string Mov { get; set; }
        public string MovID { get; set; }
        public string ID { get; set; }
        public string Cliente { get; set; }
        public BuscarPendienteEntrega()
        {
            InitializeComponent();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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
                DataTable dt = InvConsultas.BuscarPendienteEntrega(UsuarioIniciado.Almacen, Buscar, FechaD, FechaH);
                cfgPendientesEntrega.DataSource = dt;
                Formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Buscar Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Formato()
        {
            cfgPendientesEntrega.Cols["Mov"].Width = 120;
            cfgPendientesEntrega.Cols["FechaEmision"].Width = 80;
            cfgPendientesEntrega.Cols["Cliente"].Width = 80;
            cfgPendientesEntrega.Cols["Origen"].Width = 120;
            cfgPendientesEntrega.Cols["MovID"].Width = 100;
            cfgPendientesEntrega.Cols["Nombre"].Width = 190;

            cfgPendientesEntrega.Cols["FechaEmision"].Caption = "Fecha";

            cfgPendientesEntrega.Cols["ID"].Visible = false;

            cfgPendientesEntrega.Cols["Mov"].AllowEditing = false;
            cfgPendientesEntrega.Cols["FechaEmision"].AllowEditing = false;
            cfgPendientesEntrega.Cols["Cliente"].AllowEditing = false;
            cfgPendientesEntrega.Cols["Origen"].AllowEditing = false;
            cfgPendientesEntrega.Cols["MovID"].AllowEditing = false;
            cfgPendientesEntrega.Cols["Nombre"].AllowEditing = false;
            
        }

        private void chkRango_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRango.Checked)
                dtpFechaH.Enabled = true;
            else
                dtpFechaH.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Mov = "";
                MovID = "";
                ID = "";
                Cliente = "";
                if (cfgPendientesEntrega.Row <= 0)
                    return;

                Mov = cfgPendientesEntrega[cfgPendientesEntrega.Row, "Mov"].ToString();
                MovID = cfgPendientesEntrega[cfgPendientesEntrega.Row, "MovID"].ToString();
                ID = cfgPendientesEntrega[cfgPendientesEntrega.Row, "ID"].ToString();
                Cliente = cfgPendientesEntrega[cfgPendientesEntrega.Row, "Cliente"].ToString();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Buscar Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void cfgPendientesEntrega_DoubleClick(object sender, EventArgs e)
        {
            btnAceptar_Click(btnAceptar, new EventArgs());
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnBuscar_Click(btnBuscar, new EventArgs());
        }
    }
}
