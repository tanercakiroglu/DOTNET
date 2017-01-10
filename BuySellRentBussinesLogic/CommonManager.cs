using BuySellRentBDO;
using BuySellRentDAL;
using System.Collections.Generic;

namespace BuySellRentBussinesLogic
{
    public class CommonManager
    {

        public List<CountryBDO> GetAllCountries()
        {
            CommonDAO countryDAO = new CommonDAO();
            return countryDAO.getAllCountries() ;
            
        }
    }
}
