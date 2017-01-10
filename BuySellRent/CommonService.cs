using AutoMapper;
using BuySellRentBDO;
using BuySellRentBussinesLogic;
using System.Collections.Generic;
using System.ServiceModel.Activation;

namespace BuySellRent
{
    [AutomapServiceBehavior]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class CommonService : ICommonService
    {
        public List<Country> getAllCountries()
        {

            CommonManager cl = new CommonManager();
            var list = Mapper.Map<List<CountryBDO>, List<Country>>(cl.GetAllCountries());


            return list;
        }


    }
}
