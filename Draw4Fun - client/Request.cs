using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Draw4Fun___client
{
    class Request
    {
        public string url = "http://localhost:9797";

        public void registerPost(string nickname,string password)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "/register");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"nickname\":\"" + nickname + "\"," +
                              "\"password\":\"" + password + "\"}";

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        public bool loginPost(string nickname, string password)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "/login");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"nickname\":\"" + nickname + "\"," +
                              "\"password\":\"" + password + "\"}";

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            Console.Write("Response je: " + httpResponse.ToString());
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                return Boolean.Parse(result);
            }
        }

       /* public bool imagePost(byte[] image, int senderId, int receiverId)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "/login");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"nickname\":\"" + nickname + "\"," +
                              "\"password\":\"" + password + "\"}";

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            Console.Write("Response je: " + httpResponse.ToString());
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                return Boolean.Parse(result);
            }
        }*/
    }
}
