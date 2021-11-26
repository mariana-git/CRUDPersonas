using System;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CDExecuteNonQuery : CDConnection
    {
        protected int NonQuerySP(string procedure, string nombre, string apellido, int idDoc, int numDoc, double CUIL,
            string calle, int numCalle, int piso, string depto, int idLocalidad, int idPersona)
        {
            using (SqlCommand Command = new SqlCommand())
            {
                using (Command.Connection = Connect())
                {
                    Command.CommandTimeout = 15;
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@NOMBRE", nombre);
                    Command.Parameters.AddWithValue("@APELLIDO", apellido);
                    Command.Parameters.AddWithValue("@NUMDOC", numDoc);
                    Command.Parameters.AddWithValue("@IDDOC", idDoc);
                    Command.Parameters.AddWithValue("@CUIL", CUIL);
                    Command.Parameters.AddWithValue("@CALLE", calle);
                    Command.Parameters.AddWithValue("@NUMCALLE", numCalle);
                    Command.Parameters.AddWithValue("@PISO", piso);
                    Command.Parameters.AddWithValue("@DEPTO", depto);
                    Command.Parameters.AddWithValue("@IDLOCALIDAD", idLocalidad);
                    Command.Parameters.AddWithValue("@IDPERSONA", idPersona);
                    Command.CommandText = procedure;
                    return Command.ExecuteNonQuery();
                }
            }
        }
        protected int NonQuerySP(string procedure, string nombre, string apellido, int idDoc, int numDoc, double CUIL,
            string calle, int numCalle, int piso, string depto, int idLocalidad)
        {
            using (SqlCommand Command = new SqlCommand())
            {
                using (Command.Connection = Connect())
                {
                    Command.CommandTimeout = 15;
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@NOMBRE", nombre);
                    Command.Parameters.AddWithValue("@APELLIDO", apellido);
                    Command.Parameters.AddWithValue("@NUMDOC", numDoc);
                    Command.Parameters.AddWithValue("@IDDOC", idDoc);
                    Command.Parameters.AddWithValue("@CUIL", CUIL);
                    Command.Parameters.AddWithValue("@CALLE", calle);
                    Command.Parameters.AddWithValue("@NUMCALLE", numCalle);
                    Command.Parameters.AddWithValue("@PISO", piso);
                    Command.Parameters.AddWithValue("@DEPTO", depto);
                    Command.Parameters.AddWithValue("@IDLOCALIDAD", idLocalidad);
                    Command.CommandText = procedure;
                    return Command.ExecuteNonQuery();
                }
            }
        }
        protected int NonQuerySP(string procedure, int idPersona, int idTelefono, int telefono, string referencia)
        {
            using (SqlCommand Command = new SqlCommand())
            {
                using (Command.Connection = Connect())
                {
                    Command.CommandTimeout = 15;
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@IDPERSONA", idPersona);
                    Command.Parameters.AddWithValue("@IDTELEFONO", idTelefono);
                    Command.Parameters.AddWithValue("@TELEFONO", telefono);
                    Command.Parameters.AddWithValue("@REFERENCIA", referencia);
                    Command.CommandText = procedure;
                    return Command.ExecuteNonQuery();
                }
            }
        }
        protected int NonQueryQ(string query)
        {
            using (SqlCommand Command = new SqlCommand())
            {
                using (Command.Connection = Connect())
                {
                    Command.CommandTimeout = 15;
                    Command.CommandType = CommandType.Text;
                    Command.CommandText = query;
                    return Command.ExecuteNonQuery();
                }
            }
        }
    }
}
