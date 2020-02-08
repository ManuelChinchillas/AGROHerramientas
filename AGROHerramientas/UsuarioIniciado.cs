using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROHerramientas
{
    public static class UsuarioIniciado
    {
        private static string _Usuario;
        private static string _Contraseña;
        private static List<string> _Permisos;
        private static string _Nombre;
        private static string _Almacen;
        private static int _Estacion;
        public static string Usuario
        {
            get
            {
                return _Usuario;
            }

            set
            {
                _Usuario = value;
            }
        }

        public static string Contraseña
        {
            get
            {
                return _Contraseña;
            }

            set
            {
                _Contraseña = value;
            }
        }

        public static List<string> Permisos
        {
            get
            {
                return _Permisos;
            }

            set
            {
                _Permisos = value;
            }
        }

        public static string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }

        public static string Almacen
        {
            get
            {
                return _Almacen;
            }

            set
            {
                _Almacen = value;
            }
        }

        public static int Estacion
        {
            get
            {
                return _Estacion;
            }

            set
            {
                _Estacion = value;
            }
        }
    }
}
