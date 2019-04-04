using Newtonsoft.Json;
using RestSharp;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace TinderEndpoint
{
    public class TinderAPI
    {
        public const string baseURL = @"https://api.gotinder.com";
        public const string Authenticate = @"/auth";
        public const string Authenticate2FA = @"/auth/login/accountkit";

        public const string Profile = @"/profile";

        public const string MatchRecommendations = @"/user/recs";
        public const string Message = @"/user/matches/{_id}";
        public const string Unmatch = @"/user/matches/{match_id}";
        public const string Updates = @"/updates";
        public const string Username = @"/profile/username";

        public const string Like = @"/like/{_id}";
        public const string Pass = @"/pass/{_id}";
        public const string SuperLike = @"/like/{_id}/Super";

        public const string Metadata = @"/meta";
        public const string MetadataV2 = @"/v2/meta";


    }

    public class RestMethods
    {
        //RestClient client;
        HttpWebRequest request;
        byte[] RequestContent;

        private string MakeRequest()
        {
            Stream datastream = request.GetRequestStream();
            datastream.Write(RequestContent, 0, RequestContent.Length);

            datastream.Close();

            WebResponse response = request.GetResponse();
            datastream = response.GetResponseStream();
            StreamReader reader = new StreamReader(datastream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            datastream.Close();
            response.Close();

            return responseFromServer;
        }

        public RestMethods(Guid authToken = default(Guid), string path)
        {
            //client = new RestClient(TinderAPI.baseURL);

            //client.AddDefaultHeader("Content-type", "application/json");
            //client.AddDefaultHeader("User-agent", "Tinder/7.5.3 (iPhone; iOS 10.3.2; Scale/2.00)");
            //client.AddDefaultHeader("app_version", "6.9.4");
            //client.AddDefaultHeader("platform", "ios");
            //client.AddDefaultHeader("Accept", "application/json");

            //if (authToken  != Guid.Empty)
            //    client.AddDefaultHeader("X-Auth-Token", authToken.ToString());

            request = (HttpWebRequest)WebRequest.Create(TinderAPI.baseURL + path);
            request.Headers.Add("Content-type", "application/json");
            request.Headers.Add("User-agent", "Tinder/7.5.3 (iPhone; iOS 10.3.2; Scale/2.00)");

            if (authToken != Guid.Empty)
                request.Headers.Add("X-Auth-Token", authToken.ToString());


        }
        public T Get<T>(string path)
            where T : new()
        {

            
            var request = client.Get<T>(new RestRequest(path));

            

            if (request.StatusCode == System.Net.HttpStatusCode.OK)
            {
                if (request.Data != null)
                    return request.Data;
                else
                    return JsonConvert.DeserializeObject<T>(request.Content);
            }
            else
                return default(T);

        }
        public string Get(string path)
        {

            var request = client.Get(new RestRequest(path));

            return request.Content;


        }
        public string Post( object content, Guid token = default(Guid))
        {
            //var request = new RestRequest(path);
            //request.AddJsonBody(content);


            //var response = client.Post(request);

            //return response.Content;

            string contentA = JsonConvert.SerializeObject(content);

            RequestContent = Encoding.UTF8.GetBytes(contentA);
            request.ContentLength = RequestContent.Length;
            
            request.Method = "POST";

            return MakeRequest();


        }
        public T Post<T>(string path, object content)
            where T : new()
        {

            var request = new RestRequest(path);
            request.AddJsonBody(content);

            var response = client.Post<T>(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return response.Data;
            else
                return default(T);

        }

        public string Delete(string Path)
        {
            var request = new RestRequest(Path);

            return client.Delete(request).Content;
        }
        public T Delete<T>(string Path)
            where T : new()
        {
            var request = new RestRequest(Path);

            return client.Delete<T>(request).Data;
        }

        public string Put(string Path,object obj)
        {
            var request = new RestRequest(Path);
            request.AddJsonBody(obj);
            return client.Put(request).Content;
        }
        public T Put<T>(string Path,object obj)
            where T : new()
        {
            var request = new RestRequest(Path);
            request.AddJsonBody(obj);

            return client.Put<T>(request).Data;
        }

    }


}
