using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using Newtonsoft;
namespace SpeechToText
{
    class ToneAnalyser
    {
        
        public static void Parse(ToneAnalyzerJSON JSON, string inputText)
        {            
            Newtonsoft.Json.JsonConvert.PopulateObject(getResponse(inputText), JSON);
        }
        public static string getResponse(string inputText)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                    "Basic",
                    Convert.ToBase64String(
                        Encoding.ASCII.GetBytes(
                           "bd155088-3404-4d54-b980-258b35a6a360:74Nei3KtGs1h")));
                //creating stream from string
                var stream = new MemoryStream();
                var writer = new StreamWriter(stream);
                writer.Write(inputText);
                writer.Flush();
                stream.Position = 0;
                var content = new StreamContent(stream);
                content.Headers.ContentType = new MediaTypeHeaderValue("text/plain");
                string outputText = "";
                var response = client.PostAsync("https://gateway.watsonplatform.net/tone-analyzer/api/v3/tone?version=2017-09-21", content).Result;
                if (response.IsSuccessStatusCode)
                {
                    outputText = response.Content.ReadAsStringAsync().Result;                    
                }
                return outputText;

            }        }
    }
}
