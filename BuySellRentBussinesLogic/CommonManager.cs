using BuySellRentBDO;
using BuySellRentBussinesLogic.Interface;
using BuySellRentDAL;
using System.Collections.Generic;

namespace BuySellRentBussinesLogic
{
    public class CommonManager :ICommonManager
    {

        public List<CountryBDO> GetAllCountries()
        {
            CommonDAO countryDAO = new CommonDAO();
            return countryDAO.getAllCountries() ;
            
        }
    }
}
