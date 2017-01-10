using BuySellRentBDO;
using BuySellRentBussinesLogic;
using System.Collections.Generic;

namespace BuySellRent
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CommonService : ICommonService
    {
        public List<Country> getAllCountries()
        {
         
            CommonManager cl = new CommonManager();
            var list = new List<Country>();
            translateFromBDOtoDTO(list, cl.GetAllCountries());

            return list;
        }

        private void translateFromBDOtoDTO(List<Country> Dto,List<CountryBDO> Bdo)
        {
            foreach (var item in Bdo)

            {
                var country = new Country();
                country.ID = item.ID;
                country.name = item.name;
                country.code = item.code;
                country.active = item.active;
                country.tripleCode = item.tripleCode;
                country.phoneCode = item.phoneCode;
                country.createDate = item.createDate;

                Dto.Add(country);

            }
        }
    }
}
