﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeechToText
{
    public partial class Form1 : Form
    {
        public static string lang = "hi";
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
            recordingPanel1.BringToFront();
            recordingPanel1.Visible = true;
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            //loading the panel
            summaryPanel1.BringToFront();
            summaryPanel1.Visible = true;            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel_language.Visible = !panel_language.Visible;
        }
    }
}
