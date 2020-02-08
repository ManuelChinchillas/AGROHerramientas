using Comun.Clases;
using Conexiones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROHerramientas.Inventarios
{
    public class InvConsultas
    {
        public static DataTable PendienteDeEntrega(string Lugar, string Almacen, string Estatus, string Fecha, string IDs)
        {
            try
            {
                StringBuilder Ids = new StringBuilder();
                Ids.Append(IDs);
                Ids.Replace("I", "");
                Ids.Replace("V", "");
                Ids.Replace("i", "");
                Ids.Replace("v", "");
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec AGROSPPendienteDeEntregar @Lugar, @Almacen, @Estatus, @Fecha, @IDs ");
                cmd.Parameters.Add("@Lugar", SqlDbType.VarChar).Value = Lugar;
                cmd.Parameters.Add("@Almacen", SqlDbType.VarChar).Value = Almacen;
                cmd.Parameters.Add("@Estatus", SqlDbType.VarChar).Value = Estatus;
                cmd.Parameters.Add("@Fecha", SqlDbType.VarChar).Value = Fecha;
                cmd.Parameters.Add("@IDs", SqlDbType.VarChar).Value = Ids.ToString();
                cmd.CommandText = sb.ToString();
                dt = Conexion.ExecutarADataTable(cmd);
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static DataTable ValeEntregaPendiente(string Lugar, string Almacen, string Estatus, string Fecha, string IDs)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec AGROSPValeEntregaPendiente @Lugar, @Almacen, @Estatus, @Fecha, @IDs ");
                cmd.Parameters.Add("@Lugar", SqlDbType.VarChar).Value = Lugar;
                cmd.Parameters.Add("@Almacen", SqlDbType.VarChar).Value = Almacen;
                cmd.Parameters.Add("@Estatus", SqlDbType.VarChar).Value = Estatus;
                cmd.Parameters.Add("@Fecha", SqlDbType.VarChar).Value = Fecha;
                cmd.Parameters.Add("@IDs", SqlDbType.VarChar).Value = IDs;
                cmd.CommandText = sb.ToString();
                dt = Conexion.ExecutarADataTable(cmd);
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void AgroEntregaInserta(int Estacion, string CodigoBarras, string Usuario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec spAgroEntregaInserta @EstacionTrabajo, @CodigoBarras, @Usuario");
                cmd.Parameters.Add("@EstacionTrabajo", SqlDbType.Int).Value = Estacion;
                cmd.Parameters.Add("@CodigoBarras", SqlDbType.VarChar).Value = CodigoBarras;
                cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = Usuario;
                cmd.CommandText = sb.ToString();
                Conexion.Executar(cmd);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static DataTable xpAgroEntregaMov(int Estacion)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec xpAgroEntregaMov @EstacionTrabajo");
                cmd.Parameters.Add("@EstacionTrabajo", SqlDbType.Int).Value = Estacion;
                cmd.CommandText = sb.ToString();
                dt = Conexion.ExecutarADataTable(cmd);
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void spAgroEntregaActualiza(int Estacion, string CodigoBarras)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec spAgroEntregaActualiza @EstacionTrabajo, @CodigoBarras");
                cmd.Parameters.Add("@EstacionTrabajo", SqlDbType.Int).Value = Estacion;
                cmd.Parameters.Add("@CodigoBarras", SqlDbType.VarChar).Value = CodigoBarras;
                cmd.CommandText = sb.ToString();
                Conexion.Executar(cmd);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static DataTable ActualizarEntregas(int Estatus, int Estacion, string Lugar, string Modulo)
        {
            try
            {
                if (Estatus == 3 || Estatus == 2)
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("select art.Articulo, Cantidad, SerieLote, art.Descripcion1 Descripcion from AgroEntrega a join Art art on art.Articulo = a.Articulo ");
                    if(Modulo == "VTAS")
                        sb.Append("Where art.Grupo = @Lugar and a.Estatus in (2,3) and a.Estacion = @Estacion");
                    else
                        sb.Append("Where a.Estatus in (2,3) and a.Estacion = @Estacion");
                    cmd.Parameters.Add("@Lugar", SqlDbType.VarChar).Value = Lugar;
                    cmd.Parameters.Add("@Estacion", SqlDbType.Int).Value = Estacion;
                    cmd.CommandText = sb.ToString();
                    dt = Conexion.ExecutarADataTable(cmd);
                    return dt;
                }
                else
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("select art.Articulo, Cantidad, SerieLote, art.Descripcion1 Descripcion from AgroEntrega a join Art art on art.Articulo = a.Articulo ");
                    if (Modulo == "VTAS")
                        sb.Append("Where art.Grupo = @Lugar and a.Estatus in (@Estatus) and a.Estacion = @Estacion and Cantidad > 0");
                    else
                        sb.Append("Where a.Estatus in (@Estatus) and a.Estacion = @Estacion and Cantidad > 0");
                    cmd.Parameters.Add("@Lugar", SqlDbType.VarChar).Value = Lugar;
                    cmd.Parameters.Add("@Estatus", SqlDbType.Int).Value = Estatus;
                    cmd.Parameters.Add("@Estacion", SqlDbType.Int).Value = Estacion;
                    cmd.CommandText = sb.ToString();
                    dt = Conexion.ExecutarADataTable(cmd);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void GuardaHistAgroEntrega(int Estacion, string CBMov)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec xpGuardaHistAgroEntrega @Estacion, @CBMov");
                cmd.Parameters.Add("@estacion", SqlDbType.Int).Value = Estacion;
                cmd.Parameters.Add("@CBMov", SqlDbType.VarChar).Value = CBMov;
                cmd.CommandText = sb.ToString();
                Conexion.Executar(cmd);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void EntregarTodo(int Estacion, string ID, string Modulo)
        {
            try
            {
                StringBuilder Id = new StringBuilder();
                Id.Append(ID);
                Id.Replace("I", "");
                Id.Replace("V", "");
                Id.Replace("i", "");
                Id.Replace("v", "");
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec AgroEntregarTodo @EstacionTrabajo, @IDMov, @ModuloM ");
                cmd.Parameters.Add("@EstacionTrabajo", SqlDbType.Int).Value = Estacion;
                cmd.Parameters.Add("@IDMov", SqlDbType.Int).Value = Id.ToString();
                cmd.Parameters.Add("@ModuloM", SqlDbType.VarChar).Value = Modulo; ;
                cmd.CommandText = sb.ToString();
                Conexion.Executar(cmd);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static DataTable BuscarPendienteEntregaVentas(string Almacen, string Buscar, string FechaD, string FechaH)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec AGROSPPendienteEntrega_BuscarVenta @Almacen, @Buscar, @FechaD, @FechaH");
                cmd.Parameters.Add("@Almacen", SqlDbType.VarChar).Value = Almacen;
                cmd.Parameters.Add("@Buscar", SqlDbType.VarChar).Value = Buscar;
                if(FechaD == null)
                    cmd.Parameters.Add("@FechaD", SqlDbType.VarChar).Value = DBNull.Value;
                else
                    cmd.Parameters.Add("@FechaD", SqlDbType.VarChar).Value = FechaD;
                cmd.Parameters.Add("@FechaH", SqlDbType.VarChar).Value = FechaH;
                cmd.CommandText = sb.ToString();
                dt = Conexion.ExecutarADataTable(cmd);
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static DataTable PendienteDeEntrega_Detalle(string ID)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec AGROSPPendienteEntrega_Detalle @ID");
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                cmd.CommandText = sb.ToString();
                dt = Conexion.ExecutarADataTable(cmd);
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static DataTable PendienteDeEntrega_InfoCliente(string ID)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec AGROSPPendienteEntrega_InfoCliente @ID");
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                cmd.CommandText = sb.ToString();
                dt = Conexion.ExecutarADataTable(cmd);
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static string PendienteDeEntrega_Guardar(string Origen, string OrigenMovID, string Almacen, string Observaciones, string Usuario, DataTable dt, string Contacto, string ContactoTel)
        {
            try
            {
                string ID = "";
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec AGROSPPendienteEntrega_Guardar null, null, @Origen, @OrigenMovID, @Almacen, @Observaciones, @Usuario, null, null, @Contacto, @ContactoTel ");
                cmd.Parameters.Add("@Origen", SqlDbType.VarChar).Value = Origen;
                cmd.Parameters.Add("@OrigenMovID", SqlDbType.VarChar).Value = OrigenMovID;
                cmd.Parameters.Add("@Almacen", SqlDbType.VarChar).Value = Almacen;
                cmd.Parameters.Add("@Observaciones", SqlDbType.VarChar).Value = Observaciones;
                cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = Usuario;
                cmd.Parameters.Add("@Contacto", SqlDbType.VarChar).Value = Contacto;
                cmd.Parameters.Add("@ContactoTel", SqlDbType.VarChar).Value = ContactoTel;
                sb.Append("declare @ID int ");
                sb.Append("select @ID = MAX(ID) from AGROPendienteEntrega ");
                foreach(DataRow r in dt.Rows)
                {
                    sb.Append("Exec AGROSPPendienteEntrega_GuardarD @ID, '" + r["Articulo"].ToString() + "', " + r["Cantidad"].ToString()
                                + ", " + r["Entregado"].ToString() + ", " + r["Devuelto"].ToString() + ", " + r["Pendiente"].ToString() 
                                + ", " + r["Nuevo"].ToString() + " ");
                }
                sb.Append("select @ID ");
                cmd.CommandText = FuncionesComunes.Transaccion("PendienteEntrega", sb.ToString());
                ID = Conexion.Executar(cmd);
                return ID;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable BuscarPendienteEntrega(string Almacen, string Buscar, string FechaD, string FechaH)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec AGROSPPendienteEntrega_Buscar @Almacen, @Buscar, @FechaD, @FechaH");
                cmd.Parameters.Add("@Almacen", SqlDbType.VarChar).Value = Almacen;
                cmd.Parameters.Add("@Buscar", SqlDbType.VarChar).Value = Buscar;
                if (FechaD == null)
                    cmd.Parameters.Add("@FechaD", SqlDbType.VarChar).Value = DBNull.Value;
                else
                    cmd.Parameters.Add("@FechaD", SqlDbType.VarChar).Value = FechaD;
                cmd.Parameters.Add("@FechaH", SqlDbType.VarChar).Value = FechaH;
                cmd.CommandText = sb.ToString();
                dt = Conexion.ExecutarADataTable(cmd);
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static DataTable ValeDeEntrega_Detalle(string ID)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec AGROSPValeEntrega_Detalle @ID");
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                cmd.CommandText = sb.ToString();
                dt = Conexion.ExecutarADataTable(cmd);
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static DataTable ValeDeEntrega_InfoCliente(string ID)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec AGROSPValeEntrega_InfoCliente @ID");
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                cmd.CommandText = sb.ToString();
                dt = Conexion.ExecutarADataTable(cmd);
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static string ValeEntrega_Guardar(string Origen, string OrigenMovID, string Almacen, string Observaciones, string Usuario, DataTable dt, string Contacto, string ContactoTel)
        {
            try
            {
                string ID = "";
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec AGROSPValeEntrega_Guardar @Origen, @OrigenMovID, @Almacen, @Observaciones, @Usuario, @Contacto, @ContactoTel ");
                cmd.Parameters.Add("@Origen", SqlDbType.VarChar).Value = Origen;
                cmd.Parameters.Add("@OrigenMovID", SqlDbType.VarChar).Value = OrigenMovID;
                cmd.Parameters.Add("@Almacen", SqlDbType.VarChar).Value = Almacen;
                cmd.Parameters.Add("@Observaciones", SqlDbType.VarChar).Value = Observaciones;
                cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = Usuario;
                cmd.Parameters.Add("@Contacto", SqlDbType.VarChar).Value = Contacto;
                cmd.Parameters.Add("@ContactoTel", SqlDbType.VarChar).Value = ContactoTel;
                sb.Append("declare @ID int, @IDPendiente int ");
                sb.Append("select @ID = MAX(ID) from AGROValeEntrega ");
                foreach (DataRow r in dt.Rows)
                {
                    sb.Append("Exec AGROSPValeEntrega_GuardarD @ID, '" + r["Articulo"].ToString() + "', "  + r["Pendiente"].ToString() + ", " + r["AEntregar"].ToString() + " ");
                }
                sb.Append("select @IDPendiente = ID From AGROPendienteEntrega where Mov = @Origen and MovID = @OrigenMovID ");
                sb.Append("Exec AGROSPPendienteEntrega_ActualizarEstatus @IDPendiente ");
                sb.Append("select @ID ");
                cmd.CommandText = FuncionesComunes.Transaccion("ValeEntrega", sb.ToString());
                ID = Conexion.Executar(cmd);
                return ID;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void ValeEntrega_Entrega(string Lugar, string ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec AGROSPValeEntrega_Entregar @Lugar, @ID ");
                cmd.Parameters.Add("@Lugar", SqlDbType.VarChar).Value = Lugar;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                cmd.CommandText = sb.ToString();
                Conexion.Executar(cmd);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static string PendienteEntrega_Estatus(string ID)
        {
            try
            {
                string Estatus = "";
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("Exec AGROSPPendienteEntrega_Estatus @ID ");
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                cmd.CommandText = sb.ToString();
                Estatus = Conexion.Executar(cmd);
                return Estatus;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static DataTable articuloEnCB(string CB)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                StringBuilder sb = new StringBuilder();
                sb.Append("exec AGROSPArticuloEnCB @CB ");
                cmd.Parameters.Add("@CB", SqlDbType.VarChar).Value = CB;
                cmd.CommandText = sb.ToString();
                return Conexion.ExecutarADataTable(cmd);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
