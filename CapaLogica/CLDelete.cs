using System;
using System.Collections.Generic;
using System.Linq;
using CapaDatos;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CLDelete
    {
        public string IdPersona { private get; set; }
        public string IdTelefono { private get; set; }

        public bool Personas_Delete()
        {
            if(int.TryParse(IdPersona, out int idpersona))
            {
                if (new CDDelete
                {
                    IdPersona = idpersona
                }.DeletePersona() == 1) return true;
                else return false;
            }
            else return false;
        }
        public bool PersTel_Delete()
        {
            if (int.TryParse(IdPersona, out int idpersona) &&
                int.TryParse(IdTelefono, out int idTelefono))
            {
                if (new CDDelete
                {
                    IdPersona = idpersona,
                    IdTelefono = idTelefono
                }.DeletePersTel() == 1) return true;
                else return false;
            }
            else return false;
        }
    }
}
