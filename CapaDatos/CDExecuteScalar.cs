using System;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CDExcecuteScalar : CDConnection
    {
        protected int ScalarQ(string query)
        {
            using (SqlConnection Conexion = Connect())
            {
                if (Conexion.State == ConnectionState.Open) Conexion.Close();
                Conexion.Open();
                using (SqlCommand Comando = new SqlCommand(query, Conexion))
                {
                    return Convert.ToInt32(Comando.ExecuteScalar());                    
                }
            }
        }
    }
}
