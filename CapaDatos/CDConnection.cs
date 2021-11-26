using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public abstract class CDConnection
    {
        private readonly string str;

        public CDConnection()
        {
            str = "server= localhost ; database= TPCRUD ; integrated security = true";
        }

        protected SqlConnection Connect()
        {
            SqlConnection sqlConnection = new SqlConnection(str);
            if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            sqlConnection.Open();
            return sqlConnection;
        }
    }
}
