using Conexiones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROHerramientas.Reportes
{
    public class RepConsultas
    {
        public static DataTable ReportePendientesDeEntrega(string Lugar, string FechaD, string FechaH, string Almacen, string Estatus, string Buscar)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec AGROSPReportePendienteDeEntrega @Lugar, @FechaD, @FechaH, @Almacen, @Estatus, @Buscar ");
                if(Lugar == null)
                    cmd.Parameters.Add("@Lugar", SqlDbType.VarChar).Value = DBNull.Value;
                else
                    cmd.Parameters.Add("@Lugar", SqlDbType.VarChar).Value = Lugar;
                if(FechaD == null)
                    cmd.Parameters.Add("@FechaD", SqlDbType.VarChar).Value = DBNull.Value;
                else
                    cmd.Parameters.Add("@FechaD", SqlDbType.VarChar).Value = FechaD;
                cmd.Parameters.Add("@FechaH", SqlDbType.VarChar).Value = FechaH;
                if(Almacen == null)
                    cmd.Parameters.Add("@Almacen", SqlDbType.VarChar).Value = DBNull.Value;
                else
                    cmd.Parameters.Add("@Almacen", SqlDbType.VarChar).Value = Almacen;
                if (Estatus == null)
                    cmd.Parameters.Add("@Estatus", SqlDbType.VarChar).Value = DBNull.Value;
                else
                    cmd.Parameters.Add("@Estatus", SqlDbType.VarChar).Value = Estatus;

                cmd.Parameters.Add("@Buscar", SqlDbType.VarChar).Value = Buscar;
                cmd.CommandText = sb.ToString();
                dt = Conexion.ExecutarADataTable(cmd);
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static DataTable getAlmacenesReportes()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec AGROSPGetAlmacenesReportes ");
                cmd.CommandText = sb.ToString();
                dt = Conexion.ExecutarADataTable(cmd);
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
