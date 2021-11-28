using System.Data;

namespace CapaDatos
{
    public class CDRead: CDExecuteReader
    {
        #region ATTRIBUTES
        public string Nombre { private get; set; }
        public string Apellido { private get; set; }
        public int Doc { private get; set; }
        public int IDPersona { private get; set; }
        public string Table { private get; set; }
        public string Description { private get; set; }
        public int Condition { private get; set; }
        public string Column { private get; set; }
        #endregion

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
        public DataTable CMBLoad_Search()
        {
            return ReaderQ($"SELECT * FROM {Table} WHERE {Column} = {Condition} ORDER BY {Description}");
        }
        public DataTable CMBLoad_Verify(int idLocalidad)
        {
            return ReaderQ($"SELECT * FROM Provincias P INNER JOIN Partidos PA ON P.IDPROVINCIA = PA.IDPROVINCIA " +
                $"INNER JOIN Localidades L ON L.IDPARTIDO = PA.IDPARTIDO WHERE L.IDLOCALIDAD = {idLocalidad}");
        }
    }
}
