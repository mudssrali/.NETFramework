using System;
using System.Data.SqlClient;

namespace ContactDirectory
{
    internal class DBHelper : IDisposable
    {
        String _connStr = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        SqlConnection _conn = null;
        public DBHelper ( )
        {
            _conn = new SqlConnection( _connStr );
            _conn.Open();
        }

        public int ExecuteQuery ( String sqlQuery )
        {
            SqlCommand command = new SqlCommand( sqlQuery, _conn );
            var count = command.ExecuteNonQuery();
            return count;
        }
        public Object ExecuteScalar ( String sqlQuery )
        {
            SqlCommand command = new SqlCommand( sqlQuery, _conn );
            return command.ExecuteScalar();
        }

        public SqlDataReader ExecuteReader ( String sqlQuery )
        {
            SqlCommand command = new SqlCommand( sqlQuery, _conn );
            return command.ExecuteReader();
        }

        public void Dispose ( )
        {
            if (_conn != null && _conn.State == System.Data.ConnectionState.Open)
                _conn.Close();
        }
    }
}