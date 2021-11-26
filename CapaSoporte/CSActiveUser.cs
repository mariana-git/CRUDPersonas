using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSoporte
{
    public static class CSActiveUser
    {
        public static int IdPersona {  get; set; }
        public static int IdDirectorio {  get; set; }
        public static int Intentos {  get; set; }
        public static string Usuario { get; set; }
        public static int IdPermiso { get; set; }
    }
}
