using Comun.Clases;
using Conexiones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROHerramientas.Tableros
{
    public class TabConsultas
    {
        public static DataTable Consultar(string Almacen)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec AGROSPTableroCierre_Consultar @Almacen");
                cmd.Parameters.Add("@Almacen", SqlDbType.VarChar).Value = Almacen;
                cmd.CommandText = sb.ToString();
                return Conexion.ExecutarADataTable(cmd);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static DataTable Pedidos()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec AGROSPTableroCierre_Pedidos ");
                cmd.CommandText = sb.ToString();
                return Conexion.ExecutarADataTable(cmd);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static DataTable CorteCaja()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec AGROSPTableroCierre_CorteCaja ");
                cmd.CommandText = sb.ToString();
                return Conexion.ExecutarADataTable(cmd);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static DataTable TareasCierre()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec AGROSPTareasCierre ");
                cmd.CommandText = sb.ToString();
                return Conexion.ExecutarADataTable(cmd);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static DataTable TareasCierre_Asignacion(string Tarea)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec AGROSPTareasCierre_Asignacion @Tarea");
                cmd.Parameters.Add("@Tarea", SqlDbType.VarChar).Value = Tarea;
                cmd.CommandText = sb.ToString();
                DataTable dt = Conexion.ExecutarADataTable(cmd);
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static string UnidadesDeNegocioPipes()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec AGROSPUnidadDeNegocioPipes ");
                cmd.CommandText = sb.ToString();
                string UDNS = Conexion.Executar(cmd);
                return UDNS;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static void Tareas_Guardar(string Tarea, string Mensaje)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec AGROSPTareas_Guardar @Tarea, @Mensaje");
                cmd.Parameters.Add("@Tarea", SqlDbType.VarChar).Value = Tarea;
                cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar).Value = Mensaje;
                cmd.CommandText = sb.ToString();
                Conexion.Executar(cmd);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void Tareas_GuardarAsignacion(C1.Win.C1FlexGrid.C1FlexGrid Tareas)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                foreach (C1.Win.C1FlexGrid.Row r in Tareas.Rows)
                {
                    string Tarea = r["Tarea"].ToString();
                    string Mensaje = r["Mensaje"].ToString();
                    string UnidadDeNegocio = r["UnidadDeNegocio"].ToString();
                    string Vigencia = FuncionesComunes.horaFinal(DateTime.Parse(r["Vigencia"].ToString()));
                    sb.Append("Exec AGROSPTareas_Guardar '" + Tarea + "', '" + Mensaje + "', '" + @UnidadDeNegocio + "', 'PENDIENTE', '" + @Vigencia + "' ");
                }
                cmd.CommandText = FuncionesComunes.Transaccion("TareasAsignacion", sb.ToString());
                Conexion.Executar(cmd);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void TableroCierre_Guardar(string Estatus, string Observaciones, C1.Win.C1FlexGrid.C1FlexGrid Detalle)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                SqlCommand cmd = new SqlCommand();
                sb.Append("Exec AGROSPTableroCierre @Usuario, @Almacen, @Observaciones, @Estatus ");
                cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = UsuarioIniciado.Usuario;
                cmd.Parameters.Add("@Almacen", SqlDbType.VarChar).Value = UsuarioIniciado.Almacen;
                cmd.Parameters.Add("@Observaciones", SqlDbType.VarChar).Value = "";
                cmd.Parameters.Add("@Estatus", SqlDbType.VarChar).Value = Estatus;
                sb.Append("declare @ID int ");
                sb.Append("select @ID = MAX(ID) from AGROTableroCierre ");
                foreach(C1.Win.C1FlexGrid.Row r in Detalle.Rows)
                {
                    if (r.Index == 0)
                        continue;
                    sb.Append("Exec AGROSPTableroCierreD @ID, '" + r["Actividad"].ToString() + "', '" + r["Mensaje"].ToString() + "', " + r["Cantidad"].ToString() + " ");
                }
                cmd.CommandText = FuncionesComunes.Transaccion("TableroCierre", sb.ToString());
                Conexion.Executar(cmd);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DiaCerrado(string Almacen)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                SqlCommand cmd = new SqlCommand();
                sb.Append("Exec AGROSPTableroCierre_DiaCerrado @Almacen, @FechaEmision ");
                cmd.Parameters.Add("@Almacen", SqlDbType.VarChar).Value = Almacen;
                cmd.Parameters.Add("@FechaEmision", SqlDbType.VarChar).Value = FuncionesComunes.horaInicial(DateTime.Now);
                cmd.CommandText = sb.ToString();
                string resultado = Conexion.Executar(cmd);
                if (resultado == "1")
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
