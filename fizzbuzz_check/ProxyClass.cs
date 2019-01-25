using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fizzbuzz_check
{
    public class ProxyClass           
    {
        const string BaseUrl = "http://localhost:32794/";

        readonly string _accountSid;
        readonly string _secretKey;

        public ProxyClass(string accountSid, string secretKey)
        {
            _accountSid = accountSid;
            _secretKey = secretKey;
        }

        public string GetData(int digit)
        {
            var client = new RestClient(BaseUrl);
            var request = new RestRequest();
            request.Resource = "api/fizzbuzz?digit="+digit;
            request.RequestFormat = DataFormat.Json;

            var response = client.Execute(request);
            return response.Content;
        }
    }
}
