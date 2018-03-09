using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeechToText
{
    public partial class RecordingPanel : UserControl
    {        
        public RecordingPanel()
        {
            InitializeComponent();            
        }
        
        speechtotext stt = new speechtotext();
        private void RecordingPanel_VisibleChanged(object sender, EventArgs e)
        {
            
        }
        int responseCounter = 0;
        private void Stt_ResponseReceived(object sender, ResponseEventArgs e)
        {
            textBox_interimResponse.Text = e.interimResponse;
            Form1.outputText += e.interimResponse;
            textBox_FinalResponse.Text += e.interimResponse;
            responseCounter++;
            label_log.Text = "response " + responseCounter.ToString() + " recieved";
        }

        private void button_startStopToggle_Click(object sender, EventArgs e)
        {
            if(Form1.isTranscribing)// starting the transcription session
            {
                Form1.isTranscribing = false;
                Form1.outputText = "";
                textBox_FinalResponse.Text = "";
                stt.ResponseReceived += Stt_ResponseReceived;
                stt.StartTranscribe();
                label_listening.Visible = true;
            }
            else//stopping the  transcription session
            {
                Form1.isTranscribing = false;
                label_listening.Visible = false;
                textBox_interimResponse.Text = "";
                stt.stopTranscription();
                // now loading the summary panel
            }
        }
    }
}
