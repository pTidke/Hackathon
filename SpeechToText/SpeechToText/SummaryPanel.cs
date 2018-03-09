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
    public partial class SummaryPanel : UserControl
    {
        
        public SummaryPanel()
        {
            InitializeComponent();
            toolTip1.SetToolTip(pictureBox_anger , "Anger");
            toolTip1.SetToolTip(pictureBox_confidence , "Confidence");
            toolTip1.SetToolTip(pictureBox_disgust, "Disgust");
            toolTip1.SetToolTip(pictureBox_fear, "Fear");
            toolTip1.SetToolTip(pictureBox_happy, "Happy");
            toolTip1.SetToolTip(pictureBox_sad, "Sad");
        }

        private void SummaryPanel_Load(object sender, EventArgs e)
        {

        }
        public void uploadAction()
        {
            //uploading audio file
            openFileDialog1.Filter = "Wave audio (*.wav)|*.wav|Mp3 audio (*.mp3)|*.mp3";
            string filePath;
            string outputText;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox_summary.Text = "Please wait. we are working on the file.";
                filePath = openFileDialog1.FileName;
                //requesting response from server
                if (filePath.Substring(filePath.Length - 3) == "wav")
                    outputText = speechtotext.fromWaveFile(filePath);
                else
                    outputText = speechtotext.fromMp3File(filePath);
                //parsing the json file and showing in textbox
                outputText = speechtotext.GetSummaryFromJSON(outputText);
                richTextBox_summary.Text = outputText;
                //analysing the tone of the user
                ToneSetter(outputText);
            }
            else
            {

            }
        }
        private void ToneSetter(string text)
        {
            ToneAnalyzerJSON obj = new ToneAnalyzerJSON();
            ToneAnalyser.Parse(obj, text);            
            for (int i = 0; i < obj.document_tone.tones.Length; i++)
            {
                if (obj.document_tone.tones[i].tone_id == "sadness")
                    bunifuCircleProgressbar_sad.Value = (int)(obj.document_tone.tones[i].score * 100);
                else if (obj.document_tone.tones[i].tone_id == "joy")
                    bunifuCircleProgressbar_happy.Value = (int)(obj.document_tone.tones[i].score * 100);
                else if (obj.document_tone.tones[i].tone_id == "fear")
                    bunifuCircleProgressbar_fear.Value = (int)(obj.document_tone.tones[i].score * 100);
                else if (obj.document_tone.tones[i].tone_id == "disgust")
                    bunifuCircleProgressbar_disgust.Value = (int)(obj.document_tone.tones[i].score * 100);
                else if (obj.document_tone.tones[i].tone_id == "anger")
                    bunifuCircleProgressbar_anger.Value = (int)(obj.document_tone.tones[i].score * 100);

                else if (obj.document_tone.tones[i].tone_id == "confident")
                    bunifuCircleProgressbar_confidence.Value = (int)(obj.document_tone.tones[i].score * 100);
            }
            Form1.outputText = text;
        }
        private void SummaryPanel_VisibleChanged(object sender, EventArgs e)
        {
            if(Form1.summaryCaller=="uploadPanel")
            {
                uploadAction();
            }
            else if(Form1.summaryCaller=="recordingPanel")
            {
                richTextBox_summary.Text = Form1.outputText;
                ToneSetter(Form1.outputText);
            }
        }
    }
}
