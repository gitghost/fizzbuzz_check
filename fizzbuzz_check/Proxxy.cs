using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fizzbuzz_check
{
    public class Proxxy
    {
        const string BaseUrl = "http://localhost:32794/";

        readonly string _accountSid;
        readonly string _secretKey;

        public Proxxy(string accountSid, string secretKey)
        {
            _accountSid = accountSid;
            _secretKey = secretKey;
        }


        public string GetDane(int cyferka)
        {
            var client = new RestClient(BaseUrl);
            var request = new RestRequest();
            request.Resource = "api/fizzbuzz?digit="+cyferka;
            request.RequestFormat = DataFormat.Json;


            //client.Authenticator = new HttpBasicAuthenticator(_accountSid, _secretKey);
            //request.AddParameter("AccountSid", _accountSid, ParameterType.UrlSegment); // used on every request
            var response = client.Execute(request);

            return response.Content;
        }
    }
}
