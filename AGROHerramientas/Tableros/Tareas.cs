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
    public partial class Tareas : Form
    {
        public Tareas()
        {
            InitializeComponent();
        }

        private void cfgTareas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if ((cfgTareas.Row == cfgTareas.Rows.Count -1) || cfgTareas.Row == -1)
                {
                    if (cfgTareas.Rows.Count > 0)
                        cfgTareas.Rows.Add();
                }
            }
        }

        private void cfgAsignacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if ((cfgAsignacion.Row == cfgAsignacion.Rows.Count - 1) || cfgAsignacion.Row == -1)
                {
                    if (cfgAsignacion.Rows.Count > 0)
                        cfgAsignacion.Rows.Add();
                }
            }
        }

        private void Tareas_Load(object sender, EventArgs e)
        {
            try
            {
                cfgTareas.DataSource = TabConsultas.TareasCierre();
                cfgAsignacion.DataSource = TabConsultas.TareasCierre_Asignacion("");
                cfgAsignacion.Cols["UnidadDeNegocio"].ComboList = TabConsultas.UnidadesDeNegocioPipes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Tareas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cfgTareas_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                if (cfgTareas.Cols[cfgTareas.Col].Name == "Mensaje")
                {
                    if(cfgTareas[e.Row, "Tarea"] == null || cfgTareas[e.Row, "Tarea"].ToString() == "")
                    {
                        MessageBox.Show("Debe de indicar la tarea para este mensaje", "Tareas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    TabConsultas.Tareas_Guardar(cfgTareas[e.Row, "Tarea"].ToString(), cfgTareas[e.Row, "Mensaje"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
