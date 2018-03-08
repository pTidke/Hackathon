using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechToText
{
    public class ToneAnalyzerJSON
    {
        public Document_Tone document_tone { get; set; }
        public Sentences_Tone[] sentences_tone { get; set; }
    }

    public class Document_Tone
    {
        public Tone[] tones { get; set; }
    }

    public class Tone
    {
        public float score { get; set; }
        public string tone_id { get; set; }
        public string tone_name { get; set; }
    }

    public class Sentences_Tone
    {
        public int sentence_id { get; set; }
        public string text { get; set; }
        public Tone1[] tones { get; set; }
    }

    public class Tone1
    {
        public float score { get; set; }
        public string tone_id { get; set; }
        public string tone_name { get; set; }
    }


}
