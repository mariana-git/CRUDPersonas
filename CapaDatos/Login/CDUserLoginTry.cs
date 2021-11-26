using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Login
{
    public class CDUserLoginTry : CDExecuteNonQuery
    {
        public string Usuario { private get; set; }
        public int Intentos { private get; set; }

        public int UpdateUserLoginTry()
        {
            return NonQueryQ($"UPDATE Usuarios SET INTENTOS = {Intentos} WHERE USUARIO = '{Usuario}'");
        }

        public int BlockUserLoginTry()
        {
            return NonQueryQ($"UPDATE Usuarios SET IDDIRECTORIO = 2 WHERE USUARIO = '{Usuario}'");
        }

    }
}
