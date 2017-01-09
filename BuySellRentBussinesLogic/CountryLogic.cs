using BuySellRentBDO;
using BuySellRentDAL;
using System.Collections.Generic;

namespace BuySellRentBussinesLogic
{
    public class CountryLogic
    {

        public List<CountryBDO> GetAllCountries()
        {
            CountryDAO countryDAO = new CountryDAO();
            return countryDAO.getAllCountries() ;
            
        }
    }
}
