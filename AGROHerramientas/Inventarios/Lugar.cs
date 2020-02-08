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
    public partial class Lugar : Form
    {
        public string LugarIndicado { get; set; }
        public Lugar()
        {
            InitializeComponent();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Lugar_Load(object sender, EventArgs e)
        {
            try
            {
                cmbLugar.Text = FuncionesComunes.getAppSetting("Lugar");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Lugar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionesComunes.modificarAppSetting("Lugar", cmbLugar.Text);
                this.LugarIndicado = cmbLugar.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Lugar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
