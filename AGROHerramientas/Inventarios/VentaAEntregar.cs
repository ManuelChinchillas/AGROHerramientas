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
    public partial class VentaAEntregar : Form
    {
        public event EventHandler Mi_Click;
        public string Mov { get; set; }
        public string MovID { get; set; }
        public string Detalle { get; set; }
        public string ID { get; set; }
        public string Agente { get; set; }
        public string Cliente { get; set; }
        private int Hr { get; set; }
        private int Min { get; set; }
        private int Seg { get; set; }
        public VentaAEntregar()
        {
            InitializeComponent();
            Hr = 0;
            Min = 0;
            Seg = 0;
        }

        private void VentaAEntregar_Load(object sender, EventArgs e)
        {
            lblMovID.Text = Mov + " " + MovID;
            lblAgente.Text = Agente;
            lblDetalle.Text = Detalle;
            lblCliente.Text = Cliente;
            if(Mov == "ValeEntrega")
            {
                panelDegradado.ColorArriba = Color.FromArgb(93, 93, 129);
                panelDegradado.ColorAbajo = Color.FromArgb(93, 93, 129);
            }
            timer.Start();
            timerEstatus.Start();
        }

        private void panelDegradado_Click(object sender, EventArgs e)
        {
            if (Mi_Click != null)
                Mi_Click(this, e);
        }

        private void lblDetalle_Click(object sender, EventArgs e)
        {
            if (Mi_Click != null)
                Mi_Click(this, e);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Seg++;
            if(Seg == 60)
            {
                Min++;
                Seg = 0;
            }

            if(Min == 60)
            {
                Hr++;
                Min = 0;
            }

            lblTiempo.Text = Hr.ToString("00") + ":" + Min.ToString("00") + ":" + Seg.ToString("00");
        }

        private void timerEstatus_Tick(object sender, EventArgs e)
        {
            try
            {
                string estatus = InvConsultas.PendienteEntrega_Estatus(ID.ToString());
                if(estatus == "CANCELADO")
                {
                    panelDegradado.ColorArriba = Color.FromArgb(233, 79, 55);
                    panelDegradado.ColorAbajo = Color.FromArgb(233, 79, 55);
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
