using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace TinderEndpoint
{
    public static class TinderAPI
    {
        public const string baseURL = @"https://api.gotinder.com";
        public const string Authenticate = @"/v3/auth/login?locale=en";


        public const string MesssagedMatches = @"/v2/matches?count=100";
        public const string UnesssagedMatches = @"/v2/matches?count=100&message=0";




        // funciona

        public const string Updates = @"/updates";
        public const string Username = @"/profile/username";

        public const string MatchRecommendations = @"/v2/recs/core";
        public const string Message = @"/user/matches/{MatchId}";
        public const string SeenMessage = @"/v2/seen/{MatchId}/{MessageId}";


        public const string Profile = @"/v2/profile?include=likes,user,account";
        public const string Like = @"/like/{_id}";
        public const string Pass = @"/pass/{_id}";
        public const string SuperLike = @"/like/{_id}/Super";
        public const string Unmatch = @"/user/matches/{match_id}";


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

        public RestMethods(string path,string authToken = "")
        {

            request = (HttpWebRequest)WebRequest.Create(TinderAPI.baseURL + path);
            request.Headers.Add("Content-type", "application/json");
            request.Headers.Add("User-agent", "Tinder/7.5.3 (iPhone; iOS 10.3.2; Scale/2.00)");

            if (authToken != "")
                request.Headers.Add("X-Auth-Token", authToken.ToString());


        }

        public T Get<T>()
            where T : new()
        {
            string content = Get();
            Wrapper<T> obj = new Wrapper<T>();

            if (content != null) 
                obj = JsonConvert.DeserializeObject<Wrapper<T>>(content);

            return obj.data;
        }
        public string Get()
        {

            request.Method = "GET";

            return MakeRequest();

        }
        public string Post(object content = null)
        {
            if (content != null)
            {
                string contentA = JsonConvert.SerializeObject(content);

                LoadContent(contentA);
            }

            request.Method = "POST";

            return MakeRequest();
        }
        public T Post<T>(object content = null)
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

        private class Wrapper <R>
        {
            public R data { get; set; }
            public Metadata Meta { get; set; }

            public class Metadata
            {
                public int Status { get; set; }
            }
        }
    }


}
