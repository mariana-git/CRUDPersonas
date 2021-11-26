using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Login
{
    public class CDUserLoginValidate: CDExcecuteScalar
    {
        public string Usuario { private get; set; }
        public string Clave { private get; set; }


        public int Users_Search()
        {
            return ScalarQ($"SELECT COUNT(*) FROM Usuarios WHERE USUARIO = '{Usuario}'");
        }
        public int UsersPass_Search()
        {
            return ScalarQ($"SELECT COUNT(*) FROM Usuarios WHERE USUARIO = '{Usuario}' AND CLAVE = '{Clave}'");
        }
        public int UsersLoginTry_Search()
        {
            return ScalarQ($"SELECT INTENTOS FROM Usuarios WHERE USUARIO = '{Usuario}'");
        }
        public int UsersDirectory_Search()
        {
            return ScalarQ($"SELECT IDDIRECTORIO FROM Usuarios WHERE USUARIO = '{Usuario}'");
        }
    }
}
