using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDUpdate: CDExecuteNonQuery
    {
        #region Attributes
        public string Nombre { private get; set; }
        public string Apellido { private get; set; }
        public string Calle { private get; set; }
        public string Depto { private get; set; }
        public string Referencia { private get; set; }
        public int IdDoc { private get; set; }
        public int NumDoc { private get; set; }
        public int NumCalle { private get; set; }
        public int Piso { private get; set; }
        public int IdLocalidad { private get; set; }
        public int Telefono { private get; set; }
        public int IdTelefono { private get; set; }
        public int IdPersona { private get; set; }
        public double CUIL { private get; set; }

        # endregion

        public int UpdatePersona()
        {
            return NonQuerySP("spPersonas_Update",Nombre,Apellido,IdDoc,NumDoc,CUIL,Calle,NumCalle,Piso,Depto,IdLocalidad,IdPersona);
        }
        public int UpdatePersTel()
        {
            return NonQuerySP("spPersTel_Update", IdPersona, IdTelefono, Telefono, Referencia);
        }
    }
}
