using System;
using System.Data.SqlClient;

namespace BuySellRentDAL
{
    public abstract  class BaseDAO
    {
        protected  SqlConnection connection = null;
        private const string connString = "Data Source=188.121.44.212;Initial Catalog=assetsDB;User ID=assets-user;Password=Sa123456";

        private SqlConnection getConnection()
        {
            if (connection == null)
                return connection = new SqlConnection(connString);

            return connection;

        }

        protected void closeConneciton()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    connection.Close();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

        protected SqlDataReader ExecuteQuery(string sqlQuery)
        {
            var conn = getConnection();
            conn.Open();
            SqlCommand sqlCommand = null;
            sqlCommand = new SqlCommand(sqlQuery, conn);

            return sqlCommand.ExecuteReader();
        }

        protected void ExecuteNonQuery(string sqlQuery, params SqlParameter[] parameters)
        {
            var conn = getConnection();
            conn.Open();
            SqlCommand sqlCommand = null;
            sqlCommand = new SqlCommand(sqlQuery, conn);
            sqlCommand.Parameters.AddRange(parameters);
            sqlCommand.ExecuteNonQuery();
        }
    }
}
