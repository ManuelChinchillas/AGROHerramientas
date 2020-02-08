using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGROHerramientas.Tableros
{
    public partial class TableroMovimientos : Form
    {
        public DataTable Detalle { get; set; }
        public TableroMovimientos()
        {
            InitializeComponent();
        }

        private void TableroMovimientos_Load(object sender, EventArgs e)
        {
            cfgDetalle.DataSource = Detalle;
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
