namespace SpeechToText
{
    public class Rootobject
    {
        public Result[] results { get; set; }   
        public int result_index { get; set; }
    }

    public class Result
    {
        public Alternative[] alternatives { get; set; }
        public bool final { get; set; }
    }

    public class Alternative
    {
        public float confidence { get; set; }
        public string transcript { get; set; }
    }
}
