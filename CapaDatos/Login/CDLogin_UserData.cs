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
            using (DataTable dt = ReaderQ($"SELECT u.IDUSUARIO,IDDIRECTORIO, USUARIO, TIPOPERM " +
                $"FROM Usuarios u, Permisos p, UsuPerm up WHERE u.IDUSUARIO = up.IDUSUARIO " +
                $"AND up.IDPERMISO = p.IDPERMISO " +
                $"AND (USUARIO = '{Usuario}' AND CLAVE = '{Clave}')"))
            {
                //cargo en la Capa Soporte los datos del usuario 
                CSActiveUser.IdUsuario = Convert.ToInt32(dt.Rows[0]["IDUSUARIO"]);
                CSActiveUser.IdDirectorio = Convert.ToInt32(dt.Rows[0]["IDDIRECTORIO"]);
                CSActiveUser.Usuario = dt.Rows[0]["USUARIO"].ToString();
                CSActiveUser.TipoPermiso = dt.Rows[0]["TIPOPERM"].ToString();
            }
            ;
        }
    }
}
