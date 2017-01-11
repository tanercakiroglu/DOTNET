using System.Collections.Generic;
using BuySellRentBDO;
using System;
using BuySellRentDAL.Interface;
using System.Data;

namespace BuySellRentDAL
{
    public class CommonDAO : BaseDAO,ICommonDAO
    {

        public List<CountryBDO> getAllCountries()
        {
            List<CountryBDO> list = null;
            CountryBDO country = null;
            try
            {
                var dataTable = ExecuteQuery(CountryQueries.SelectCountryQuery);
                if (dataTable != null && dataTable.Rows!=null && dataTable.Rows.Count>0)
                {
                    list = new List<CountryBDO>();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        country = new CountryBDO();
                        country.ID = Convert.ToInt32(row["ID"]);
                        country.name = row["NAME"].ToString();
                        country.code = row["CODE"].ToString();
                        country.phoneCode = row["PHONECODE"].ToString();
                        country.createDate = Convert.ToDateTime(row["CREATEDATE"]);
                        country.active = Convert.ToBoolean(row["IsActive"]);
                        country.tripleCode = row["TripleCode"].ToString();

                        list.Add(country);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
          
            return list;
        }
    }
}
