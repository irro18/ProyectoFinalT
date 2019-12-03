using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;


namespace TwitterClone.ServProxy
{
    public class ProxyP : IProxyP
    {
        private RestClient _client;
        private string appid = "";
        private string metrics = "metric";

        public ProxyP()
        {
            _client = new RestClient("https://restcountries.eu/rest/v2/all");
        }


        public List<CityObject> city()
        {
            var request = new RestRequest();
            var response = _client.Get<List<CityObject>>(request);
            return response.Data;
        }
    }
}
    
