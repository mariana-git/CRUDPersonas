using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos 
{
    public class CDCreate : CDExecuteNonQuery
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
        public string Piso { private get; set; }
        public int IdLocalidad { private get; set; }
        public int Telefono { private get; set; }
        public int IdTelefono { private get; set; }
        public int IdPersona { private get; set; }
        public double CUIL { private get; set; }
        # endregion

        public int CreatePersona()
        {
            return NonQuerySP("spPersonas_Create", Nombre, Apellido, IdDoc, NumDoc, CUIL, Calle, NumCalle, Piso, Depto, IdLocalidad);
        }
        public int CreatePersTel()
        {
            return NonQuerySP("spPersTel_Create", IdPersona, IdTelefono, Telefono, Referencia);
        }
    }
}
