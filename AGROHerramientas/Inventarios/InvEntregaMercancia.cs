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
    public partial class InvEntregaMercancia : Form
    {
        
        private List<string> IDs { get; set; }
        public string Lugar { get; set; }

        private List<string> Vales { get; set; }
        public InvEntregaMercancia()
        {
            InitializeComponent();
            IDs = new List<string>();
            Vales = new List<string>();
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if(txtID.Text == "V0000001")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                txtID.Text = "V0000001";
                txtID.ForeColor = Color.Silver;
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtID.Text == "")
                {
                    MessageBox.Show("Debe de indicar el Id del movimiento", "Entrega de Mercancia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                EntregaDeMercancia em = new EntregaDeMercancia();
                em.ID = txtID.Text;//.Substring(1);
                if (txtID.Text.Contains("I") || txtID.Text.Contains("i"))
                {
                    em.Modulo = "INV";
                    em.ModuloClave = "I";
                    em.Lugar = this.Lugar;
                }
                else
                {
                    em.Modulo = "VTAS";
                    em.ModuloClave = "V";
                    em.Lugar = this.Lugar;
                }
                if (em.ShowDialog() == DialogResult.OK)
                {
                    this.IDs.Remove(em.ID);
                    if (this.fpContenedor.Controls[em.ID] != null)
                        this.fpContenedor.Controls[em.ID].Dispose();
                    txtID.Text = "";
                    txtID.Focus();
                }
                else
                {
                    txtID.Text = "V0000001";
                    txtID.ForeColor = Color.Silver;
                    txtID.Focus();
                }
            }
        }

        private string split(List<string> IDs)
        {
            string sp = "";
            if (IDs == null)
                return sp;
            foreach(string s in IDs)
                sp += "," + s;
            return sp;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                DataTable val = InvConsultas.ValeEntregaPendiente(Lugar, UsuarioIniciado.Almacen, "PENDIENTE", FuncionesComunes.horaInicial(DateTime.Today), split(Vales));
                if (val != null && val.Rows.Count > 0)
                {
                    VentaAEntregar va = new VentaAEntregar();
                    va.Mi_Click += new System.EventHandler(this.Entrega_Click);
                    va.ID = val.Rows[0]["ID"].ToString();
                    va.Mov = val.Rows[0]["Mov"].ToString();
                    va.MovID = val.Rows[0]["MovID"].ToString();
                    va.Agente = val.Rows[0]["Usuario"].ToString();
                    va.Cliente = val.Rows[0]["Cliente"].ToString();
                    va.Name = "Vale" + va.ID.ToString();
                    foreach (DataRow r in val.Rows)
                    {
                        va.Detalle += r["Cantidad"].ToString() + " - " + r["Articulo"].ToString() + ": " + r["Descripcion"].ToString() + '\n';
                    }
                    va.TopLevel = false;
                    fpContenedor.Controls.Add(va);
                    Vales.Add(va.ID.ToString());
                    va.Show();
                }

                DataTable dt = InvConsultas.PendienteDeEntrega(Lugar, UsuarioIniciado.Almacen, "POR ENTREGAR", FuncionesComunes.horaInicial(DateTime.Today), split(IDs));
                if(dt!=null && dt.Rows.Count > 0)
                {
                    VentaAEntregar ve = new VentaAEntregar();
                    ve.Mi_Click += new System.EventHandler(this.Entrega_Click);
                    ve.ID = "V" + dt.Rows[0]["ID"].ToString();
                    ve.Mov = dt.Rows[0]["Mov"].ToString();
                    ve.MovID = dt.Rows[0]["MovID"].ToString();
                    ve.Agente = dt.Rows[0]["Agente"].ToString();
                    ve.Cliente = dt.Rows[0]["Cliente"].ToString();
                    ve.Name = ve.ID.ToString();
                    foreach(DataRow r in dt.Rows)
                    {
                        ve.Detalle += r["Cantidad"].ToString() + " - " + r["Articulo"].ToString() + ": " + r["Descripcion"].ToString() + '\n';
                    }
                    ve.TopLevel = false;
                    fpContenedor.Controls.Add(ve);
                    IDs.Add(ve.ID.ToString());
                    ve.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Entrega de Mercancia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Entrega_Click(object sender, EventArgs e)
        {
            try
            {
                if (((VentaAEntregar)sender).Mov == "ValeEntrega")
                {
                    string valeid = ((VentaAEntregar)sender).ID;
                    InvConsultas.ValeEntrega_Entrega(Lugar, valeid.ToString());
                    if (this.fpContenedor.Controls["Vale" + valeid] != null)
                    {
                        this.fpContenedor.Controls["Vale" + valeid].Dispose();
                        this.Vales.Remove(valeid.ToString());
                    }
                    txtID.Text = "V0000001";
                    txtID.ForeColor = Color.Silver;
                    txtID.Focus();
                }
                else
                {
                    EntregaDeMercancia em = new EntregaDeMercancia();
                    em.ID = ((VentaAEntregar)sender).ID.ToString();
                    em.Modulo = "VTAS";
                    em.ModuloClave = "V";
                    em.Lugar = this.Lugar;
                    if (em.ShowDialog() == DialogResult.OK)
                    {
                        if (this.fpContenedor.Controls[em.ID] != null)
                        {
                            this.fpContenedor.Controls[em.ID].Dispose();
                            this.IDs.Remove(em.ID);
                        }
                        txtID.Text = "V0000001";
                        txtID.ForeColor = Color.Silver;
                        txtID.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Entrega de Mercancia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
