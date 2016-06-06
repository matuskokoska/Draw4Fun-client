using System;
using System.Collections;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
            //Console.Write("Response je: " + httpResponse.ToString());
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                
                dynamic data = JsonConvert.DeserializeObject(result);
                Boolean success = data.success;
                User.id = data.id;
                
                return success;
            }
        }

        public void imagePost(int wordId,int painter,int receiver,string image)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "/drawings/new");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"wordid\":\"" + wordId + "\"," +
                              "\"painter\":\"" + painter + "\"," +
                              "\"receiver\":\"" + receiver + "\"," +
                              "\"stream\":\"" + image + "\"}";

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                Console.Write("result image je: "+result);            
            }
        }

        public string getWords()
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "/words");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                return result;
                //Console.Write("Response 3 je: " + result);
            }
        }

        public void friendList(int id)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "/friendships");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"id\":\"" + id + "\"}";

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

        public void guessPost(string guess, int painter, int receiver)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "/guess");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"painter\":\"" + painter + "\", \"receiver\":\"" + receiver + "\", \"guess\":\"" + guess + "\"}";

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

        public String getLeaderboard()
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "/users/leaderboard");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                return result;
            }
        }

        public GuessInfo getGuess(int userId)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "/drawings/get");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"userid\":\"" + userId + "\"}";

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                GuessInfo guess = new GuessInfo();
                //Console.Write("RESULT JE : " + result);
                if (result != "[]")
                {
                    dynamic data = JsonConvert.DeserializeObject(result);
                    
                    guess.drawingId = data.id;
                    guess.word = data.word;
                    guess.painterId = data.painterid;
                    guess.nickname = data.nickname;
                    guess.datePainted = data.datepainted;

                    return guess;
                }
                else
                {
                    return guess;
                }
            }
        }

    }
}
