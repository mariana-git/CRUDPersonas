using System;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CDExecuteReader : CDConnection
    {
        protected DataTable ReaderSP(string procedure)
        {
            using (SqlCommand Command = new SqlCommand())
            {
                using (Command.Connection = Connect())
                {
                    Command.CommandTimeout = 15;
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.CommandText = procedure;
                    SqlDataReader leer = Command.ExecuteReader();
                    using (DataTable DT = new DataTable())
                    {
                        DT.Load(leer);
                        return DT;
                    }
                }                
            }
        }
        protected DataTable ReaderSP(string procedure, string nombre, string apellido, int doc, int idPersona)
        {
            using (SqlCommand Command = new SqlCommand())
            {
                using (Command.Connection = Connect())
                {
                    Command.CommandTimeout = 15;
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@NOMBRE", nombre);
                    Command.Parameters.AddWithValue("@APELLIDO", apellido);
                    Command.Parameters.AddWithValue("@NUMDOC", doc);
                    Command.Parameters.AddWithValue("@IDPERSONA", idPersona);
                    Command.CommandText = procedure;
                    SqlDataReader leer = Command.ExecuteReader();
                    using (DataTable DT = new DataTable())
                    {
                        DT.Load(leer);
                        return DT;
                    }
                }
            }
        }
        protected DataTable ReaderSP(string procedure, int idPersona)
        {
            using (SqlCommand Command = new SqlCommand())
            {
                using (Command.Connection = Connect())
                {
                    Command.CommandTimeout = 15;
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@IDPERSONA", idPersona);
                    Command.CommandText = procedure;
                    SqlDataReader leer = Command.ExecuteReader();
                    using (DataTable DT = new DataTable())
                    {
                        DT.Load(leer);
                        return DT;
                    }
                }
            }
        }
        protected DataTable ReaderQ(string query)
        {
            using (SqlCommand Command = new SqlCommand())
            {
                using (Command.Connection = Connect())
                {
                    Command.CommandTimeout = 15;
                    Command.CommandType = CommandType.Text;
                    Command.CommandText = query;
                    SqlDataReader leer = Command.ExecuteReader();
                    using (DataTable DT = new DataTable())
                    {
                        DT.Load(leer);
                        return DT;
                    }
                }
            }
        }
    }
}
