using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace BuySellRent
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICommonService
    {

        [OperationContract]
        [WebInvoke(Method = "GET",
                               ResponseFormat = WebMessageFormat.Json,
                               BodyStyle = WebMessageBodyStyle.Wrapped,
                               UriTemplate = "getAllCountries")]
        List<Country> getAllCountries();
    }

    [DataContract]
    public class Country
    {
        [DataMember]
        public long ID;
        [DataMember]
        public string name;
        [DataMember]
        public string code;
        [DataMember]
        public string tripleCode;
        [DataMember]
        public int order;
        [DataMember]
        public DateTime createDate;
        [DataMember]
        public bool active;
        [DataMember]
        public string phoneCode;
    }
}
