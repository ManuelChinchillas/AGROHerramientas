using Conexiones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROHerramientas
{
    public class Log_In
    {
        public static string Usuario(string usuario, string contraseña)
        {
            try
            {
                string Nombre;
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec AGROSPgetUsuario @usuario, @Pass ");
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = contraseña;
                cmd.CommandText = sb.ToString();
                Nombre = Conexion.Executar(cmd);
                return Nombre;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static DataTable Almacenes()
        {
            try
            {
                DataTable dt;
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec AGROSPObtenerAlmacenes");
                cmd.CommandText = sb.ToString();
                dt = Conexion.ExecutarADataTable(cmd);
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static DataTable UsuarioValores(string usuario)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec AGROSPUsuarioValores @usuario");
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                cmd.CommandText = sb.ToString();
                dt = Conexion.ExecutarADataTable(cmd);
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static DataTable UsuarioPermisos(string usuario)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec AGROSPPermisosUsuario @usuario");
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
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
