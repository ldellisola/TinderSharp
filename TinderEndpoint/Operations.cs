using Newtonsoft.Json;
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
        HttpWebRequest request;
        byte[] RequestContent;

        private string MakeRequest()
        {
            try
            {
                Stream datastream;
                if (request.Method != "GET")
                {
                    datastream = request.GetRequestStream();
                    datastream.Write(RequestContent, 0, RequestContent.Length);

                    datastream.Close();
                }

                WebResponse response = request.GetResponse();
                datastream = response.GetResponseStream();
                StreamReader reader = new StreamReader(datastream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();

                datastream.Close();
                response.Close();

                return responseFromServer;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        private void LoadContent(string content)
        {
            RequestContent = Encoding.UTF8.GetBytes(content);
            request.ContentLength = RequestContent.Length;
        }

        public RestMethods(string path,Guid authToken = default(Guid))
        {

            request = (HttpWebRequest)WebRequest.Create(TinderAPI.baseURL + path);
            request.Headers.Add("Content-type", "application/json");
            request.Headers.Add("User-agent", "Tinder/7.5.3 (iPhone; iOS 10.3.2; Scale/2.00)");

            if (authToken != Guid.Empty)
                request.Headers.Add("X-Auth-Token", authToken.ToString());


        }
        public T Get<T>()
            where T : new()
        {

            string content = Get();
            T obj = default(T);

            if (content != null) 
                obj = JsonConvert.DeserializeObject<T>(content);

            return obj;
        }
        public string Get()
        {

            request.Method = "GET";

            return MakeRequest();

        }
        public string Post(object content)
        {
            string contentA = JsonConvert.SerializeObject(content);

            LoadContent(contentA);
            
            request.Method = "POST";

            return MakeRequest();
        }
        public T Post<T>(object content)
            where T : new()
        {
            string response = Post(content);

            T obj = default(T);

            if (content != null)
                obj = JsonConvert.DeserializeObject<T>(response);

            return obj;
        }

        public string Delete()
        {
            request.Method = "DELETE";

            return MakeRequest();
        }
        public T Delete<T>()
            where T : new()
        {

            string content = Delete();

            T obj = default(T);

            if (content != null)
                obj = JsonConvert.DeserializeObject<T>(content);

            return obj;
        }

        public string Put(object obj)
        {

            string content = JsonConvert.SerializeObject(obj);

            LoadContent(content);

            request.Method = "PUT";

            return MakeRequest();
        }
        public T Put<T>(object obj)
            where T : new()
        {

            string response = Put(obj);

            T objResponse = default(T);

            if (response != null)
                objResponse = JsonConvert.DeserializeObject<T>(response);
            return objResponse;
        }

    }


}
