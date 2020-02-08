using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGROHerramientas.Inventarios
{
    public partial class ValeEntrega : Form
    {
        private string ID { get; set; }
        private string Mov { get; set; }
        private string MovID { get; set; }
        private C1.Win.C1FlexGrid.CellStyle cs;

        private string ValeID { get; set; }
        public ValeEntrega()
        {
            InitializeComponent();
            cs = cfgArticulos.Styles.Add("Indicador");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarPendienteEntrega bPendiente = new BuscarPendienteEntrega();
                if(bPendiente.ShowDialog() == DialogResult.OK)
                {
                    ID = bPendiente.ID;
                    Mov = bPendiente.Mov;
                    MovID = bPendiente.MovID;
                    txtMovimiento.Text = Mov + " " + MovID;
                    DataTable dt = InvConsultas.ValeDeEntrega_InfoCliente(ID);
                    txtClienteNombre.Text = dt.Rows[0]["Nombre"].ToString();
                    txtNoCliente.Text = dt.Rows[0]["Cliente"].ToString();
                    txtCorreo.Text = dt.Rows[0]["Correo"].ToString();
                    txtTelefono.Text = dt.Rows[0]["Telefonos"].ToString();
                    cfgArticulos.DataSource = InvConsultas.ValeDeEntrega_Detalle(ID);
                    Formato();
                    btnGuardar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Vale Entrega", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Formato()
        {
            cfgArticulos.Cols["Articulo"].Width = 70;
            cfgArticulos.Cols["Descripcion"].Width = 540;
            cfgArticulos.Cols["Pendiente"].Width = 80;
            cfgArticulos.Cols["AEntregar"].Width = 80;

            cfgArticulos.Cols["Articulo"].AllowDragging = false;
            cfgArticulos.Cols["Descripcion"].AllowDragging = false;
            cfgArticulos.Cols["Pendiente"].AllowDragging = false;
            cfgArticulos.Cols["AEntregar"].AllowDragging = false;

            cfgArticulos.Cols["Articulo"].AllowEditing = false;
            cfgArticulos.Cols["Descripcion"].AllowEditing = false;
            cfgArticulos.Cols["Pendiente"].AllowEditing = false;
            cfgArticulos.Cols["AEntregar"].AllowEditing = true;

            cfgArticulos.Cols["Articulo"].AllowResizing = false;
            cfgArticulos.Cols["Descripcion"].AllowResizing = true;
            cfgArticulos.Cols["Pendiente"].AllowResizing = false;
            cfgArticulos.Cols["AEntregar"].AllowResizing = false;

            cfgArticulos.Cols["Articulo"].AllowSorting = false;
            cfgArticulos.Cols["Descripcion"].AllowSorting = false;
            cfgArticulos.Cols["Pendiente"].AllowSorting = false;
            cfgArticulos.Cols["AEntregar"].AllowSorting = false;
            
            cfgArticulos.Cols["Pendiente"].Format = "N4";
            cfgArticulos.Cols["AEntregar"].Format = "N4";

            cfgArticulos.Cols["AEntregar"].Caption = "A Entregar";


            cs.BackColor = Color.FromArgb(153, 180, 209);
            cfgArticulos.Cols["AEntregar"].Style = cs;
        }

        private void cfgArticulos_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                double Pendiente = double.Parse(cfgArticulos[e.Row, "Pendiente"].ToString());
                double AEntregar = double.Parse(cfgArticulos[e.Row, "AEntregar"].ToString());
                if (AEntregar < 0)
                {
                    MessageBox.Show("El A Entregar no puede ser menor que 0", "Vale de Entrega", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cfgArticulos[e.Row, "AEntregar"] = Pendiente;
                    return;
                }
                if (AEntregar > Pendiente)
                {
                    MessageBox.Show("El A Entregar no puede ser mayor a la Cantidad Pendiente", "Vale de Entrega", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cfgArticulos[e.Row, "AEntregar"] = Pendiente;
                }
                else
                {
                    cfgArticulos[e.Row, "Pendiente"] = Pendiente - AEntregar;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Vale de Entrega", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtContacto.Text == "")
                {
                    MessageBox.Show("El campo de contacto debe de llevar informacion", "Vale de Entrega", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (txtConTel.Text == "")
                {
                    MessageBox.Show("El campo de contacto tel debe de llevar informacion", "Vale de Entrega", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataTable dt = (DataTable)cfgArticulos.DataSource;
                ValeID = InvConsultas.ValeEntrega_Guardar(Mov, MovID, UsuarioIniciado.Almacen, txtObservaciones.Text, UsuarioIniciado.Usuario, dt, txtContacto.Text, txtConTel.Text);
                MessageBox.Show("El Vale de Entrega se ha guardado con Exito", "Vale de Entrega", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGuardar.Enabled = false;
                pnlPrincipal.Enabled = false;
                btnImprimir.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Vale de Entrega", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ID = "";
            Mov = "";
            Mov = "";
            ValeID = "";
            cfgArticulos.DataSource = null;
            cfgArticulos.Rows.Count = 1;
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                ReportDocument document = new ReportDocument();
                document.Load("Reportes\\ValeEntrega.rpt");
                CrystalReportViewer crvVisor = new CrystalReportViewer();
                crvVisor.ReportSource = document;
                document.SetParameterValue("@ID", ValeID);
                string strServer = ConfigurationManager.AppSettings["ServerName"].ToString();
                string strDatabase = ConfigurationManager.AppSettings["DataBaseName"].ToString();
                string strUserID = ConfigurationManager.AppSettings["UserId"].ToString();
                string strPwd = ConfigurationManager.AppSettings["Password"].ToString();
                document.DataSourceConnections[0].SetConnection(strServer, strDatabase, strUserID, strPwd);

                //Pendiente Entrega
                ReportDocument document2 = new ReportDocument();
                document2.Load("Reportes\\PendienteEntrega.rpt");
                CrystalReportViewer crvVisor2 = new CrystalReportViewer();
                crvVisor2.ReportSource = document2;
                document2.SetParameterValue("@ID", ID);
                document2.DataSourceConnections[0].SetConnection(strServer, strDatabase, strUserID, strPwd);

                PrintDialog pd = new PrintDialog();
                if (pd.ShowDialog() == DialogResult.OK)
                {
                    document.PrintOptions.PrinterName = pd.PrinterSettings.PrinterName;
                    document.PrintToPrinter(1, true, 0, 0);

                    document2.PrintOptions.PrinterName = pd.PrinterSettings.PrinterName;
                    document2.PrintToPrinter(2, true, 0, 0);//Se imprien 2
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
