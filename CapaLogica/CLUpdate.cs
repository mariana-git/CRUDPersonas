using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaLogica
{
    public class CLUpdate
    {
        #region Attributes
        public string Nombre { private get; set; }
        public string Apellido { private get; set; }
        public string Calle { private get; set; }
        public string Depto { private get; set; }
        public string IdDoc { private get; set; }
        public string NumDoc { private get; set; }
        public string NumCalle { private get; set; }
        public string Piso { private get; set; }
        public string IdLocalidad { private get; set; }
        public string IdPersona { private get; set; }
        public string CUIL { private get; set; }
        public string IdTelefono { private get; set; }
        public string Referencia { private get; set; }
        public string Telefono { private get; set; }
        #endregion

        public bool Personas_Update()
        {
            if (double.TryParse(CUIL, out double cUIL) &&
                int.TryParse(IdDoc, out int idDoc) &&
                int.TryParse(NumDoc, out int numDoc) &&
                int.TryParse(NumCalle, out int numCalle) &&
                int.TryParse(IdLocalidad, out int idlocalidad) &&
                int.TryParse(IdPersona, out int idpersona) 
                )
            {
                if (new CDUpdate
                {
                    IdPersona = idpersona,
                    Nombre = Nombre.ToUpper(),
                    Apellido = Apellido.ToUpper(),
                    IdDoc = idDoc,
                    NumDoc = numDoc,
                    CUIL = cUIL,
                    Calle = Calle.ToUpper(),
                    NumCalle = numCalle,
                    Piso = Piso,
                    Depto = Depto,
                    IdLocalidad = idlocalidad
                }.UpdatePersona() == 1) return true;
                else return false;
            }
            else return false;
        }
        public bool PersTel_Update()
        {
            if (
                int.TryParse(Telefono, out int telefono) &&
                int.TryParse(IdTelefono, out int idTelefono) &&
                int.TryParse(IdPersona, out int idPersona)
                )
            {
                if (new CDUpdate
                {
                    IdPersona = idPersona,
                    IdTelefono = idTelefono,
                    Telefono = telefono,
                    Referencia = Referencia.ToUpper()
                }.UpdatePersTel() == 1) return true;
                else return false;
            }
            else return false;
        }
    }
}
