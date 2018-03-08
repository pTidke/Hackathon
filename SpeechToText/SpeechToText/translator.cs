using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace SpeechToText
{
    class translator
    {
        public static string _apiKey = "trnsl.1.1.20180307T211340Z.c8ce0e240e55c0a2.d1bb1b162d6beb272f223d88d676f826ec613db1";

        public static List<string> Translate(string lang, string text)
        {
            var requestString = String.Format("https://translate.yandex.net/api/v1.5/tr.json/translate?key={0}&text={1}&lang={2}&format={3}", _apiKey, text, lang, "plain");
            var request = WebRequest.Create(requestString);
            if ((requestString.Length > 10240) && (request.Method.StartsWith("GET")))
                throw new ArgumentException("Text is too long (>10Kb)");
            var response = request.GetResponse();

            TranslateData translateData;
            var yandexDataContractSerializer = new DataContractJsonSerializer(typeof(TranslateData));
            try
            {
                translateData = (TranslateData)yandexDataContractSerializer.ReadObject(response.GetResponseStream());
            }
            catch (Exception exception)
            {
                translateData = new TranslateData();
                translateData.Text = new List<string>();
            }
            translateData.Text.ForEach(i => Console.Write("{0}\t", i));
            return translateData.Text;
        }
        [DataContract]
        internal class TranslateData
        {
            [DataMember(Name = "code")]
            internal int Code { get; set; }
            [DataMember(Name = "lang")]
            internal string Lang { get; set; }
            [DataMember(Name = "text")]
            internal List<string> Text { get; set; }
        }
        [DataContract]
        public class GetLangsData
        {
            [DataMember(Name = "dirs")]
            internal List<string> Dirs { get; set; }
        }
        [DataContract]
        internal class DetectData
        {
            [DataMember(Name = "code")]
            internal int Code { get; set; }
            [DataMember(Name = "lang")]
            internal string Lang { get; set; }
        }
    }
}
