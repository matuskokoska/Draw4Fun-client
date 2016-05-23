using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Draw4Fun___client
{
    class Request
    {
        static void nieco(string[] args)
        {
            getRequest("http://www.microsoft.com");
            postRequest("http://posttestserver.com/post.php");
        }

        async static void getRequest(string url)
        {
            using (HttpClient client=new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    using (HttpContent content = response.Content)
                    {
                        //string mycontent = await content.ReadAsStringAsync();
                        HttpContentHeaders headers = content.Headers;

                        Console.WriteLine(headers);
                    }
                }
            }
        }

        async static void postRequest(string url)
        {
            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>(){
                new KeyValuePair<string, string>("query1","jamal"),
                new KeyValuePair<string, string>("query2", "hussain")
            };

            HttpContent q = new FormUrlEncodedContent(queries);
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.PostAsync(url,q))
                {
                    using (HttpContent content = response.Content)
                    {
                        string mycontent = await content.ReadAsStringAsync();
                        HttpContentHeaders headers = content.Headers;

                        Console.WriteLine(mycontent);
                    }
                }
            }
        }


    }
}
