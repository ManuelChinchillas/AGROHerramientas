using AGROHerramientas.Inventarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System.Configuration;

namespace AGROHerramientas
{
    public partial class PendienteDeEntrega : Form
    {
        private string ID { get; set; }
        private string Mov { get; set; }
        private string MovID { get; set; }
        private C1.Win.C1FlexGrid.CellStyle cs;

        private string PendienteID { get; set; }
        public PendienteDeEntrega()
        {
            InitializeComponent();
            cs = cfgArticulos.Styles.Add("Indicador");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarPendienteEntregaVentas buscar = new BuscarPendienteEntregaVentas();
                if(buscar.ShowDialog() == DialogResult.OK)
                {
                    ID = buscar.ID;
                    Mov = buscar.Mov;
                    MovID = buscar.MovID;
                    txtMovimiento.Text = Mov + " " + MovID;
                    DataTable dt = InvConsultas.PendienteDeEntrega_InfoCliente(ID);
                    txtClienteNombre.Text = dt.Rows[0]["Nombre"].ToString();
                    txtNoCliente.Text = dt.Rows[0]["Cliente"].ToString();
                    txtCorreo.Text = dt.Rows[0]["Correo"].ToString();
                    txtTelefono.Text = dt.Rows[0]["Telefonos"].ToString();
                    cfgArticulos.DataSource = InvConsultas.PendienteDeEntrega_Detalle(ID);
                    Formato();
                    btnGuardar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Pendiente de Entrega", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Formato()
        {
            cfgArticulos.Cols["Articulo"].Width = 70;
            cfgArticulos.Cols["Descripcion"].Width = 300;
            cfgArticulos.Cols["Cantidad"].Width = 80;
            cfgArticulos.Cols["Entregado"].Width = 80;
            cfgArticulos.Cols["Devuelto"].Width = 80;
            cfgArticulos.Cols["Pendiente"].Width = 80;
            cfgArticulos.Cols["Nuevo"].Width = 80;

            cfgArticulos.Cols["Articulo"].AllowDragging = false;
            cfgArticulos.Cols["Descripcion"].AllowDragging = false;
            cfgArticulos.Cols["Cantidad"].AllowDragging = false;
            cfgArticulos.Cols["Entregado"].AllowDragging = false;
            cfgArticulos.Cols["Devuelto"].AllowDragging = false;
            cfgArticulos.Cols["Pendiente"].AllowDragging = false;
            cfgArticulos.Cols["Nuevo"].AllowDragging = false;

            cfgArticulos.Cols["Articulo"].AllowEditing = false;
            cfgArticulos.Cols["Descripcion"].AllowEditing = false;
            cfgArticulos.Cols["Cantidad"].AllowEditing = false;
            cfgArticulos.Cols["Entregado"].AllowEditing = false;
            cfgArticulos.Cols["Devuelto"].AllowEditing = false;
            cfgArticulos.Cols["Pendiente"].AllowEditing = false;
            cfgArticulos.Cols["Nuevo"].AllowEditing = true;

            cfgArticulos.Cols["Articulo"].AllowResizing = false;
            cfgArticulos.Cols["Descripcion"].AllowResizing = true;
            cfgArticulos.Cols["Cantidad"].AllowResizing = false;
            cfgArticulos.Cols["Entregado"].AllowResizing = false;
            cfgArticulos.Cols["Devuelto"].AllowResizing = false;
            cfgArticulos.Cols["Pendiente"].AllowResizing = false;
            cfgArticulos.Cols["Nuevo"].AllowResizing = false;

            cfgArticulos.Cols["Articulo"].AllowSorting = false;
            cfgArticulos.Cols["Descripcion"].AllowSorting = false;
            cfgArticulos.Cols["Cantidad"].AllowSorting = false;
            cfgArticulos.Cols["Entregado"].AllowSorting = false;
            cfgArticulos.Cols["Devuelto"].AllowSorting = false;
            cfgArticulos.Cols["Pendiente"].AllowSorting = false;
            cfgArticulos.Cols["Nuevo"].AllowSorting = false;

            cfgArticulos.Cols["Cantidad"].Format = "N2";
            cfgArticulos.Cols["Entregado"].Format = "N2";
            cfgArticulos.Cols["Devuelto"].Format = "N2";
            cfgArticulos.Cols["Pendiente"].Format = "N2";
            cfgArticulos.Cols["Nuevo"].Format = "N2";


            cs.BackColor = Color.FromArgb(153, 180, 209);
            cfgArticulos.Cols["Nuevo"].Style = cs;
        }

        private void cfgArticulos_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                double Cantidad = double.Parse(cfgArticulos[e.Row, "Cantidad"].ToString());
                double Devuelto = double.Parse(cfgArticulos[e.Row, "Devuelto"].ToString());
                double Nuevo = double.Parse(cfgArticulos[e.Row, "Nuevo"].ToString());
                double Pendiente = double.Parse(cfgArticulos[e.Row, "Pendiente"].ToString());
                double Entregado = double.Parse(cfgArticulos[e.Row, "Entregado"].ToString());
                if (Nuevo < 0)
                {
                    MessageBox.Show("El nuevo pendiente no puede ser menor que 0", "Pendiente de Entrega", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cfgArticulos[e.Row, "Nuevo"] = Cantidad - Devuelto;
                    return;
                }
                if(Nuevo > (Cantidad - Devuelto))
                {
                    MessageBox.Show("El nuevo pendiente no puede ser mayor a la Cantidad original menos lo ya Devuelto", "Pendiente de Entrega", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Nuevo = Cantidad - Devuelto;
                    cfgArticulos[e.Row, "Nuevo"] = Nuevo;
                    cfgArticulos[e.Row, "Pendiente"] = Nuevo;
                    cfgArticulos[e.Row, "Entregado"] = Entregado - Nuevo;
                }
                else
                {
                    cfgArticulos[e.Row, "Pendiente"] = Nuevo;
                    cfgArticulos[e.Row, "Entregado"] = Cantidad - Nuevo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Pendiente de Entrega", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ID = "";
            Mov = "";
            Mov = "";
            PendienteID = "";
            cfgArticulos.DataSource = null;
            cfgArticulos.Rows.Count = 1;
            cfgArticulos.Rows.Fixed = 1;
            pnlPrincipal.Enabled = true;
            btnGuardar.Enabled = false;
            btnImprimir.Enabled = false;
            txtMovimiento.Text = "";
            txtClienteNombre.Text = "";
            txtNoCliente.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtObservaciones.Text = "";
            txtContacto.Text = "";
            txtConTel.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtContacto.Text == "")
                {
                    MessageBox.Show("El campo de contacto debe de llevar informacion", "Pendiente de Entrega", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if(txtConTel.Text == "")
                {
                    MessageBox.Show("El campo de contacto tel debe de llevar informacion", "Pendiente de Entrega", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataTable dt = (DataTable)cfgArticulos.DataSource;
                PendienteID = InvConsultas.PendienteDeEntrega_Guardar(Mov, MovID, UsuarioIniciado.Almacen, txtObservaciones.Text, UsuarioIniciado.Usuario, dt, txtContacto.Text, txtConTel.Text);
                MessageBox.Show("El pendiente se ha guardado con Exito", "Pendiente de Entrega", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGuardar.Enabled = false;
                pnlPrincipal.Enabled = false;
                btnImprimir.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Pendiente de Entrega", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                ReportDocument document = new ReportDocument();
                document.Load("Reportes\\PendienteEntrega.rpt");
                CrystalReportViewer crvVisor = new CrystalReportViewer();
                crvVisor.ReportSource = document;
                document.SetParameterValue("@ID", PendienteID);
                string strServer = ConfigurationManager.AppSettings["ServerName"].ToString();
                string strDatabase = ConfigurationManager.AppSettings["DataBaseName"].ToString();
                string strUserID = ConfigurationManager.AppSettings["UserId"].ToString();
                string strPwd = ConfigurationManager.AppSettings["Password"].ToString();
                document.DataSourceConnections[0].SetConnection(strServer, strDatabase, strUserID, strPwd);
                PrintDialog pd = new PrintDialog();
                if (pd.ShowDialog() == DialogResult.OK)
                {
                    document.PrintOptions.PrinterName = pd.PrinterSettings.PrinterName;
                    document.PrintToPrinter(2, true, 0, 0);
                }
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Pendiente de Entrega", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
