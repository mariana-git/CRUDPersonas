using CapaDatos.Login;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Login
{
    public class CLLoginValidate

    {

        public string Usuario { private get; set; }
        public string Clave { private get; set; }


        public string Login_Validate()
        {
            if (new CDUserLoginValidate { Usuario = Usuario }.Users_Search() == 1) //Valido que exista el usuario
            {
                int directorio = new CDUserLoginValidate { Usuario = Usuario }.UsersDirectory_Search();
                if (directorio == 1)
                {
                    if (new CDUserLoginValidate { Usuario = Usuario, Clave = Clave }.UsersPass_Search() == 1) // valido que exista clave y usuario
                    {
                        new CDLogin_UserData { Usuario = Usuario, Clave = Clave }.Users_Read(); //cargo los datos del usuario en la capa soporte
                        new CDUserLoginTry { Usuario = Usuario, Intentos = 0 }.UpdateUserLoginTry();// limpio INTENTOS
                        return "";
                    }
                    else
                    {
                        int intentos = new CDUserLoginValidate { Usuario = Usuario }.UsersLoginTry_Search();
                        new CDUserLoginTry { Usuario = Usuario, Intentos = intentos + 1 }.UpdateUserLoginTry(); //incremento INTENTOS
                        if (intentos < 2)                                                                       //valido que sean menos de 3 INTENTOS
                        {
                            return "Constraseña Incorrecta";
                        }
                        else
                        {
                            new CDUserLoginTry { Usuario = Usuario }.BlockUserLoginTry();
                            return "Usuario Bloqueado";
                        }
                    }
                }
                else
                {
                    if (directorio == 2) return "Usuario Bloqueado";
                    else return "Usuario Desactivado";
                }
            }
            else return "Usuario inexistente";
        }
    }
}
