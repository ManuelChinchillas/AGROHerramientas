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

namespace AGROHerramientas.Reportes
{
    public partial class ReportePendientesDeEntrega : Form
    {
        public ReportePendientesDeEntrega()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string Buscar = txtBuscar.Text.Replace('*', '%');
                string Estatus = cmbEstatus.Text;
                if (Estatus == "(TODOS)")
                    Estatus = null;
                string Almacen = cmbAlmacen.SelectedValue.ToString();
                if (Almacen == "(TODOS)")
                    Almacen = null;
                string Grupo = cmbGrupo.Text;
                if (Grupo == "(TODOS)")
                    Grupo = null;
                if (Buscar == "")
                    Buscar = "*";
                string FechaD = FuncionesComunes.horaInicial(dtpFechaD.Value);
                string FechaH = FuncionesComunes.horaFinal(dtpFechaH.Value);
                if (!chkRango.Checked)
                {
                    FechaD = null;
                }
                DataTable dt = RepConsultas.ReportePendientesDeEntrega(Grupo, FechaD, FechaH, Almacen, Estatus, Buscar);
                cfgDetalle.DataSource = dt;
                Formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReportePendientesDeEntrega_Load(object sender, EventArgs e)
        {
            try
            {
                cmbEstatus.Text = "(TODOS)";
                cmbGrupo.Text = "(TODOS)";
                cmbAlmacen.ValueMember = "Almacen";
                cmbAlmacen.DisplayMember = "Nombre";
                cmbAlmacen.DataSource = RepConsultas.getAlmacenesReportes();
                cmbAlmacen.Text = "(TODOS)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Formato()
        {
            foreach(C1.Win.C1FlexGrid.Column c in cfgDetalle.Cols)
                cfgDetalle.Cols[c.Index].Visible = false;

            cfgDetalle.Cols["PendienteMovID"].AllowEditing = false;
            cfgDetalle.Cols["PendienteFechaEmision"].AllowEditing = false;
            cfgDetalle.Cols["NombreCliente"].AllowEditing = false;
            cfgDetalle.Cols["Almacen"].AllowEditing = false;
            cfgDetalle.Cols["PendienteArticulo"].AllowEditing = false;
            cfgDetalle.Cols["PendienteDescripcion"].AllowEditing = false;
            cfgDetalle.Cols["PendientePendiente"].AllowEditing = false;

            cfgDetalle.Cols["PendienteMovID"].AllowDragging = false;
            cfgDetalle.Cols["PendienteFechaEmision"].AllowEditing = false;
            cfgDetalle.Cols["NombreCliente"].AllowEditing = false;
            cfgDetalle.Cols["Almacen"].AllowEditing = false;
            cfgDetalle.Cols["PendienteArticulo"].AllowEditing = false;
            cfgDetalle.Cols["PendienteDescripcion"].AllowEditing = false;
            cfgDetalle.Cols["PendientePendiente"].AllowEditing = false;

            cfgDetalle.Cols["PendienteMovID"].Caption = "MovID";
            cfgDetalle.Cols["PendienteFechaEmision"].Caption = "FechaEmision";
            cfgDetalle.Cols["NombreCliente"].Caption = "Cliente";
            cfgDetalle.Cols["Almacen"].Caption = "Almacen";
            cfgDetalle.Cols["PendienteArticulo"].Caption = "Articulo";
            cfgDetalle.Cols["PendienteDescripcion"].Caption = "Descripcion";
            cfgDetalle.Cols["PendientePendiente"].Caption = "Pendiente";

            cfgDetalle.Cols["PendienteMovID"].Width = 100;
            cfgDetalle.Cols["PendienteFechaEmision"].Width = 113;
            cfgDetalle.Cols["NombreCliente"].Width = 300;
            cfgDetalle.Cols["Almacen"].Width = 70;
            cfgDetalle.Cols["PendienteArticulo"].Width = 64;
            cfgDetalle.Cols["PendienteDescripcion"].Width = 300;
            cfgDetalle.Cols["PendientePendiente"].Width = 94;

            cfgDetalle.Cols["PendienteMovID"].Visible = true;
            cfgDetalle.Cols["PendienteFechaEmision"].Visible = true;
            cfgDetalle.Cols["NombreCliente"].Visible = true;
            cfgDetalle.Cols["Almacen"].Visible = true;
            cfgDetalle.Cols["PendienteArticulo"].Visible = true;
            cfgDetalle.Cols["PendienteDescripcion"].Visible = true;
            cfgDetalle.Cols["PendientePendiente"].Visible = true;


        }

        private void chkRango_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaH.Enabled = chkRango.Checked;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Data Files (*.xls)|*.xls";
                save.DefaultExt = "xls";
                save.AddExtension = true;
                if (save.ShowDialog() == DialogResult.OK)
                    cfgDetalle.SaveExcel(save.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
