using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace restAPI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://cat-fact.herokuapp.com/facts/");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string jsonText = await response.Content.ReadAsStringAsync();
            //Console.WriteLine(await response.Content.ReadAsStringAsync());
            Rootobject catFacts = new Rootobject();

            Console.ReadLine();

        }

        public class Rootobject
        {
            public Class1[] Property1 { get; set; }
        }

        public class Class1
        {
            public Status status { get; set; }
            public string _id { get; set; }
            public string user { get; set; }
            public string text { get; set; }
            public int __v { get; set; }
            public string source { get; set; }
            public DateTime updatedAt { get; set; }
            public string type { get; set; }
            public DateTime createdAt { get; set; }
            public bool deleted { get; set; }
            public bool used { get; set; }
        }

        public class Status
        {
            public bool verified { get; set; }
            public int sentCount { get; set; }
        }

    }
}
