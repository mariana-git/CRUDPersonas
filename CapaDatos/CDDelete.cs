namespace CapaDatos
{
    public class CDDelete : CDExecuteNonQuery
    {
        public int IdPersona { private get; set; }
        public int IdTelefono { private get; set; }

        public int DeletePersona()
        {
            return NonQueryQ($"UPDATE Personas SET IDDIRECTORIO = 3 WHERE IDPERSONA = {IdPersona}");
        }

        public int DeletePersTel()
        {
            return NonQueryQ($"DELETE FROM PersTel WHERE IDPERSONA = {IdPersona} AND IDTELEFONO = {IdTelefono}");
        }
    }
}
