using System;

namespace BuySellRentBDO
{
    public class CountryBDO
    {
        public long ID {get;set;}
        public string name {get;set;}
        public string code {get;set;}
        public string tripleCode {get;set;}
        public int order {get;set;}
        public DateTime createDate {get;set;}
        public bool active {get;set;}
        public string phoneCode {get;set;}
    }
}
