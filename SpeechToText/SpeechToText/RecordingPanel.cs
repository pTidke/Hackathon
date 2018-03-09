using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SpeechToText
{
    public partial class RecordingPanel : UserControl
    {
        //public Image bkg = Image.FromFile(@"C:\Users\prajw\Documents\GitHub\Hackathon\SpeechToText\SpeechToText\resources\icons8_Block_Microphone_40px");
        public RecordingPanel()
        {
            InitializeComponent();            
        }

        public event ResponseEventHandler TranscriptionStopped;
        public virtual void OnTranscriptionStopped(ResponseEventArgs e)
        {
            TranscriptionStopped(this, e);
        }
        speechtotext stt = new speechtotext();
        private void RecordingPanel_VisibleChanged(object sender, EventArgs e)
        {
            textBox_FinalResponse.Text = "";
            textBox_interimResponse.Text = "";
            textBox_interimTranslated.Text = "";
            //label_log.Text = "Log";
        }
        int responseCounter = 0;
        string interimResponse;
        private void Stt_ResponseReceived(object sender, ResponseEventArgs e)
        {
            e.interimResponse =  e.interimResponse.Replace("%HESITATION", " .... ");
            interimResponse = e.interimResponse;
            textBox_interimResponse.Text = e.interimResponse;            
            textBox_FinalResponse.Text += e.interimResponse;
            responseCounter++;
            //label_log.Text = "response " + responseCounter.ToString() + " recieved";
            Task.Run(() => translate_interim());
        }
        public void translate_interim()
        {
            if (!Form1.lang.Equals("none"))
            {
                string temp;
                if (Form1.lang.Equals("hi"))
                    temp = "hi";
                else if (Form1.lang.Equals("ta"))
                    temp = "ta";
                else
                    temp = "te";
                textBox_interimTranslated.Text = translator.Translate(temp, interimResponse);

            }
        }
        private void button_startStopToggle_Click(object sender, EventArgs e)
        {
            if ((Form1.isTranscribing) && (this.Visible == true))// starting the transcription session
            {

                button_startStopToggle.Image = new Bitmap(SpeechToText.Properties.Resources.micStop);
                Form1.isTranscribing = false;
                Form1.outputText = "";
                textBox_FinalResponse.Text = "";
                textBox_interimResponse.Text = "";
                textBox_interimTranslated.Text = "";
                stt.ResponseReceived += Stt_ResponseReceived;
                stt.StartTranscribe();
                label_listening.Visible = true;
            }
            else//stopping the  transcription session
            {
                button_startStopToggle.Image = new Bitmap(SpeechToText.Properties.Resources.micOn);
                Form1.isTranscribing = false;
                label_listening.Visible = false;
                textBox_interimResponse.Text = "";
                stt.stopTranscription();
                OnTranscriptionStopped(new ResponseEventArgs(textBox_FinalResponse.Text));
                // now loading the summary panel
            }
        }

        private void button_startStopToggle_MouseLeave(object sender, EventArgs e)
        {
            //this.button_startStopToggle.Image = bkg;
            //this.button_startStopToggle.Image = SpeechToText.Properties.Resources.micStop;
        }

        private void button_startStopToggle_MouseEnter(object sender, EventArgs e)
        {
            //this.button_startStopToggle.Image = SpeechToText.Properties.Resources.micOn;
        }
    }
}
