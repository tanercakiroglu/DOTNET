using AutoMapper;
using BuySellRentBDO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuySellRent
{
    public class AutomapBootstrap

	 {

	      public static void InitializeMap()

	      {
            #pragma warning disable CS0618 // Type or member is obsolete
            Mapper.CreateMap<CountryBDO, Country>();
        }

	  }
}
