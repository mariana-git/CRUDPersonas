using System;
using System.Collections.Generic;
using System.Data;
using CapaSoporte;
using System.Threading.Tasks;

namespace CapaDatos.Login
{
    public class CDLogin_UserData : CDExecuteReader
    {

        public string Usuario { private get; set; }
        public string Clave { private get; set; }

        public void Users_Read()
        {
            using (DataTable dt = ReaderQ($"SELECT IDPERSONA,IDDIRECTORIO, INTENTOS, USUARIO, " +
                $"IDPERMISO  FROM Usuarios WHERE USUARIO = '{Usuario}' AND CLAVE = '{Clave}'"))
            {
                //cargo en la Capa Soporte los datos del usuario 
                CSActiveUser.IdPersona = Convert.ToInt32(dt.Rows[0]["IDPERSONA"]);
                CSActiveUser.IdDirectorio = Convert.ToInt32(dt.Rows[0]["IDDIRECTORIO"]);
                CSActiveUser.Intentos = Convert.ToInt32(dt.Rows[0]["INTENTOS"]);
                CSActiveUser.Usuario = dt.Rows[0]["USUARIO"].ToString();
                CSActiveUser.IdPermiso = Convert.ToInt32(dt.Rows[0]["IDPERMISO"]);
            }
            ;
        }
    }
}
