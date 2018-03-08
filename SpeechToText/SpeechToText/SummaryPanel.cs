﻿using System;
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
        }

        private void SummaryPanel_Load(object sender, EventArgs e)
        {

        }

        private void SummaryPanel_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible == true)
            {
                //uploading audio file
                openFileDialog1.Filter = "Wave audio (*.wav)|*.wav|Mp3 audio (*.mp3)|*.mp3";
                string filePath;
                string outputText;
                richTextBox_summary.Text = "Please wait. we are working on the file.";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
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
                    ToneAnalyzerJSON obj = new ToneAnalyzerJSON();
                    ToneAnalyser.Parse(obj, outputText);
                    for (int i = 0; i < obj.document_tone.tones.Length; i++)
                    {
                        if (obj.document_tone.tones[i].tone_id == "sadness")
                            bunifuCircleProgressbar_sad.Value = (int)(obj.document_tone.tones[i].score * 100);
                       else if (obj.document_tone.tones[i].tone_id == "joy")
                            bunifuCircleProgressbar_happy.Value = (int)(obj.document_tone.tones[i].score * 100);
                        else if (obj.document_tone.tones[i].tone_id == "fear")
                            bunifuCircleProgressbar_fear.Value = (int)(obj.document_tone.tones[i].score * 100);
                        else if (obj.document_tone.tones[i].tone_id == "disgust")
                            bunifuCircleProgressbar_neutral.Value = (int)(obj.document_tone.tones[i].score * 100);
                        else if (obj.document_tone.tones[i].tone_id == "anger")
                            bunifuCircleProgressbar_anger.Value = (int)(obj.document_tone.tones[i].score * 100);
                       
                    }
                }
                else
                {
                    
                }
            }
        }
    }
}
