using System.Collections.Generic;
using System.Data.SqlClient;
using BuySellRentBDO;
using System;

namespace BuySellRentDAL
{
    public class CountryDAO
    {

        public List<CountryBDO> getAllCountries()
        {
            string connString = "Data Source=188.121.44.212;Initial Catalog=assetsDB;User ID=assets-user;Password=Sa123456";
            SqlCommand sqlCommand;
            string sql = null;
            SqlDataReader reader;
            var list = new List<CountryBDO>();
            SqlConnection sqlConnection1 = new SqlConnection(connString);

            try
            {
                sqlConnection1.Open();
                sql = "SELECT  * FROM dbo.Country";
                sqlCommand = new SqlCommand(sql, sqlConnection1);
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    var country = new CountryBDO();
                    country.ID = reader.GetInt32(0);
                    country.name = reader.GetString(2);
                    country.code = reader.GetString(1);
                    country.active = reader.GetBoolean(7);
                    country.tripleCode = reader.GetString(4);
                    country.phoneCode = reader.GetString(3);
                    country.createDate = reader.GetDateTime(6);

                    list.Add(country);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }


            reader.Close();
            sqlCommand.Dispose();
            sqlConnection1.Close();

            return list;
        }
    }
}
