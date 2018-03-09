using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace SpeechToText
{
    public partial class Form1 : Form
    {
        public static string outputText = "";
        public static string lang = "none";
        public static bool isTranscribing = false;
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            toolTip1.SetToolTip(button_record , "Record Audio");
            toolTip1.SetToolTip(button_upload , "Attach Audio");
            toolTip1.SetToolTip(button_language, "Change Language");
            toolTip1.SetToolTip(button_hindiLanguage, "Hindi");
            toolTip1.SetToolTip(button_tamilLanguage, "Tamil");
            toolTip1.SetToolTip(button_teluguLanguage, "Telugu");
            toolTip1.SetToolTip(button, "Close Application");
            toolTip1.SetToolTip(button2, "Minimize Application");
            recordingPanel1.TranscriptionStopped += RecordingPanel1_TranscriptionStopped;
        }

        public static string summaryCaller = "none";
        private void RecordingPanel1_TranscriptionStopped(object sender, ResponseEventArgs e)
        {
            outputText = e.interimResponse;
            summaryCaller = "recordingPanel";
            summaryPanel1.BringToFront();
            summaryPanel1.Visible = false;
            summaryPanel1.Visible = true;
        }

        private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_record_Click(object sender, EventArgs e)
        {
            //label_listening.Visible = !label_listening.Visible;
            isTranscribing = true;
            outputText = "";
            //MessageBox.Show(Path.GetTempPath());
            recordingPanel1.Visible = false;
            recordingPanel1.BringToFront();           
            recordingPanel1.Visible = true;
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            //loading the panel
            outputText = "";
            summaryCaller = "uploadPanel";
            summaryPanel1.BringToFront();
            summaryPanel1.Visible = false;
            summaryPanel1.Visible = true;              
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel_language.Visible = !panel_language.Visible;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
        }
        private void setSummaryTranslation()
        {
            if (outputText != null && outputText != "")
            {                
                string trans_output = translator.Translate(lang, outputText);

                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] encodedBytes = utf8.GetBytes(trans_output);
                //MessageBox.Show(trans_output);
                //textBox1.Text = trans_output;
                summaryPanel1.textBox_translation.Text = trans_output;
            }
        }
        private void button_hindiLanguage_Click(object sender, EventArgs e)
        {
            lang = "hi";
            setSummaryTranslation();
            label2.Text = "HIN";
            panel_language.Visible = !panel_language.Visible;
            label2.ForeColor = Color.White;
            
        }

        private void button_tamilLanguage_Click(object sender, EventArgs e)
        {
            lang = "ta";
            setSummaryTranslation();
            label2.Text = "TAM";
            panel_language.Visible = !panel_language.Visible;
            label2.ForeColor = Color.White;
            
        }

        private void button_teluguLanguage_Click(object sender, EventArgs e)
        {
            lang = "te";
            setSummaryTranslation();
            label2.Text = "TEL";
            panel_language.Visible = !panel_language.Visible;
            label2.ForeColor = Color.White;            
        }
    }
}
