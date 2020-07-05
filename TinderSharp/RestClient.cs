using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TinderSharp.Models.Exceptions;

namespace TinderSharp
{
    public class RestClient
    {
        HttpWebRequest request;
        byte[] RequestContent;

        private const string baseURL = @"https://api.gotinder.com";


        private async Task<string> MakeRequest()
        {

            Stream datastream;
            if (request.Method != "GET")
            {
                datastream = await request.GetRequestStreamAsync();
                await datastream.WriteAsync(RequestContent, 0, RequestContent.Length);
                datastream.Close();
            }

            WebResponse response = await request.GetResponseAsync();
            datastream = response.GetResponseStream();
            StreamReader reader = new StreamReader(datastream);
            // Read the content.
            string responseFromServer = await reader.ReadToEndAsync();

            datastream.Close();
            response.Close();

            return responseFromServer;

        }

        private void LoadContent(string content)
        {
            RequestContent = Encoding.UTF8.GetBytes(content);
            request.ContentLength = RequestContent.Length;
        }

        public RestClient(string path, string authToken = "")
        {

            request = (HttpWebRequest)WebRequest.Create(baseURL + path);
            request.Headers.Add("Content-type", "application/json");
            request.Headers.Add("User-agent", "Tinder/7.5.3 (iPhone; iOS 10.3.2; Scale/2.00)");

            if (authToken != "")
                request.Headers.Add("X-Auth-Token", authToken);


        }

        public async Task<T> Get<T>() where T : new()
        {
            string content = await Get();
            Wrapper<T> obj = new Wrapper<T>();

            if (content != null)
                obj = JsonConvert.DeserializeObject<Wrapper<T>>(content);

            if (obj.Meta.Status == (int)HttpStatusCode.Unauthorized)
                throw new UnauthorizedUserException();

            if (obj.Meta.Status != 200)
                throw new UnkownTinderException(obj.Meta.Status);

            return obj.data;
        }
        public async Task<string> Get()
        {

            request.Method = "GET";

            return await MakeRequest();

        }
        public async Task<string> Post(object content = null)
        {
            if (content != null)
            {
                string contentA = JsonConvert.SerializeObject(content);

                LoadContent(contentA);
            }

            request.Method = "POST";

            return await MakeRequest();
        }
        public async Task<T> Post<T>(object content = null) where T : new()
        {
            string response = await Post(content);

            T obj = default(T);

            if (content != null)
                obj = JsonConvert.DeserializeObject<T>(response);

            return obj;
        }

        public async Task<string> Delete()
        {
            request.Method = "DELETE";

            return await MakeRequest();
        }
        public async Task<T> Delete<T>() where T : new()
        {

            string content = await Delete();

            T obj = default(T);

            if (content != null)
                obj = JsonConvert.DeserializeObject<T>(content);

            return obj;
        }

        public async Task<string> Put(object obj)
        {

            string content = JsonConvert.SerializeObject(obj);

            LoadContent(content);

            request.Method = "PUT";

            return await MakeRequest();
        }
        public async Task<T> Put<T>(object obj) where T : new()
        {

            string response = await Put(obj);

            T objResponse = default(T);

            if (response != null)
                objResponse = JsonConvert.DeserializeObject<T>(response);
            return objResponse;
        }

        private class Wrapper<R>
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