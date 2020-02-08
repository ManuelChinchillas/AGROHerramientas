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
    public partial class TableroCierre : Form
    {
        public TableroCierre()
        {
            InitializeComponent();
        }

        private void cfgDetalle_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if(cfgDetalle[cfgDetalle.Row, "Actividad"].ToString() == "Pedido")
                {
                    DataTable dt = TabConsultas.Pedidos();
                    TableroMovimientos mov = new TableroMovimientos();
                    mov.Detalle = dt;
                    mov.ShowDialog();
                }
                if (cfgDetalle[cfgDetalle.Row, "Actividad"].ToString() == "Corte Caja")
                {
                    DataTable dt = TabConsultas.CorteCaja();
                    TableroMovimientos mov = new TableroMovimientos();
                    mov.Detalle = dt;
                    mov.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Tablero de Cierre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                bool DiaCerrado = TabConsultas.DiaCerrado(UsuarioIniciado.Almacen);
                if (DiaCerrado)
                {
                    MessageBox.Show("Ya hay un cierre de dia concluido", "Tablero Cierre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataTable dt = TabConsultas.Consultar(UsuarioIniciado.Almacen);
                cfgDetalle.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Tablero de Cierre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(cfgDetalle.Rows.Count > 1)
                {
                    if(MessageBox.Show("Hay actividades pendientes por realizar, ¿Desea autorizar el cierre?", "Tablero Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if(UsuarioIniciado.Permisos.Contains("2.1.1"))
                        {
                            TabConsultas.TableroCierre_Guardar("CONCLUIDO", "", cfgDetalle);
                            MessageBox.Show("El cierre del dia se ha hecho correctamente", "Tablero Cierre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        else
                        {
                            Comun.Controles.ClaveAutorizacion ca = new Comun.Controles.ClaveAutorizacion();
                            ca.Mov = "TableroCierre";
                            ca.Almacen = UsuarioIniciado.Almacen;
                            if(ca.ShowDialog() == DialogResult.OK)
                            {
                                TabConsultas.TableroCierre_Guardar("CONCLUIDO", "", cfgDetalle);
                                MessageBox.Show("El cierre del dia se ha hecho correctamente", "Tablero Cierre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show("El usuario no cuenta con permisos para realizar esta autorizacion", "Tablero Cierre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        

                    }
                }
                else
                {
                    TabConsultas.TableroCierre_Guardar("CONCLUIDO", "", cfgDetalle);
                    MessageBox.Show("El cierre del dia se ha hecho correctamente", "Tablero Cierre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Tablero de Cierre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
