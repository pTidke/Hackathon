using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SpeechToText
{
    public partial class Form2 : Form
    {
        static Thread ms_oThread = null;
        Form1 form1 = new Form1();
        public Form2()
        {
            InitializeComponent();
        }
    }
}
