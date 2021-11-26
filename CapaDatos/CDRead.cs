using System.Data;

namespace CapaDatos
{
    public class CDRead: CDExecuteReader
    {
        public string Nombre { private get; set; }
        public string Apellido { private get; set; }
        public int Doc { private get; set; }
        public int IDPersona { private get; set; }
        public string Table { private get; set; }
        public string Description { private get; set; }

        public DataTable Personas_ReadAll()
        {            
            return ReaderSP("spPersonas_ReadAll");
        }
        public DataTable Personas_Search()
        {
            return ReaderSP("spPersonas_Search",Nombre,Apellido,Doc,IDPersona);
        }
        public DataTable PersTel_Search()
        {
            return ReaderSP("spPersTel_Search", IDPersona);
        }
        public DataTable CMBLoad_ReadAll()
        {
            return ReaderQ($"SELECT * FROM {Table} ORDER BY {Description}");
        }
    }
}
