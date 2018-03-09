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
            isTranscribing = true;
        }
        bool isTranscribing = true;
        speechtotext stt = new speechtotext();
        private void RecordingPanel_VisibleChanged(object sender, EventArgs e)
        {
            if(!isTranscribing)// starting the transcription session
            {
                isTranscribing = true;
                Form1.outputText = "";
                textBox_FinalResponse.Text = "";
                stt.ResponseReceived += Stt_ResponseReceived;
                stt.StartTranscribe();              
                
            }
            else//stopping the  transcription session
            {
                isTranscribing = false;
                stt.stopTranscription();
                // now loading the summary panel
            }

        }

        private void Stt_ResponseReceived(object sender, ResponseEventArgs e)
        {
            textBox_interimResponse.Text = e.interimResponse;
            Form1.outputText += e.interimResponse;
            textBox_FinalResponse.Text += e.interimResponse;
        }
    }
}
