namespace SpeechToText
{
    partial class SummaryPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryPanel));
            this.richTextBox_summary = new System.Windows.Forms.RichTextBox();
            this.pictureBox_happy = new System.Windows.Forms.PictureBox();
            this.pictureBox_anger = new System.Windows.Forms.PictureBox();
            this.pictureBox_fear = new System.Windows.Forms.PictureBox();
            this.pictureBox_disgust = new System.Windows.Forms.PictureBox();
            this.pictureBox_sad = new System.Windows.Forms.PictureBox();
            this.pictureBox_confidence = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox_translation = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_saveToFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label_happy = new System.Windows.Forms.Label();
            this.label_angry = new System.Windows.Forms.Label();
            this.label_sad = new System.Windows.Forms.Label();
            this.label_disgust = new System.Windows.Forms.Label();
            this.label_fear = new System.Windows.Forms.Label();
            this.label_confidence = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_happy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_anger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_disgust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_confidence)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox_summary
            // 
            this.richTextBox_summary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_summary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox_summary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_summary.Location = new System.Drawing.Point(35, 35);
            this.richTextBox_summary.Name = "richTextBox_summary";
            this.richTextBox_summary.ReadOnly = true;
            this.richTextBox_summary.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.richTextBox_summary.Size = new System.Drawing.Size(780, 210);
            this.richTextBox_summary.TabIndex = 0;
            this.richTextBox_summary.Text = "";
            // 
            // pictureBox_happy
            // 
            this.pictureBox_happy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_happy.BackgroundImage")));
            this.pictureBox_happy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_happy.Location = new System.Drawing.Point(840, 41);
            this.pictureBox_happy.Name = "pictureBox_happy";
            this.pictureBox_happy.Size = new System.Drawing.Size(75, 75);
            this.pictureBox_happy.TabIndex = 3;
            this.pictureBox_happy.TabStop = false;
            // 
            // pictureBox_anger
            // 
            this.pictureBox_anger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_anger.BackgroundImage")));
            this.pictureBox_anger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_anger.Location = new System.Drawing.Point(840, 122);
            this.pictureBox_anger.Name = "pictureBox_anger";
            this.pictureBox_anger.Size = new System.Drawing.Size(75, 75);
            this.pictureBox_anger.TabIndex = 4;
            this.pictureBox_anger.TabStop = false;
            // 
            // pictureBox_fear
            // 
            this.pictureBox_fear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_fear.BackgroundImage")));
            this.pictureBox_fear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_fear.Location = new System.Drawing.Point(840, 365);
            this.pictureBox_fear.Name = "pictureBox_fear";
            this.pictureBox_fear.Size = new System.Drawing.Size(75, 75);
            this.pictureBox_fear.TabIndex = 5;
            this.pictureBox_fear.TabStop = false;
            // 
            // pictureBox_disgust
            // 
            this.pictureBox_disgust.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_disgust.BackgroundImage")));
            this.pictureBox_disgust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_disgust.Location = new System.Drawing.Point(840, 284);
            this.pictureBox_disgust.Name = "pictureBox_disgust";
            this.pictureBox_disgust.Size = new System.Drawing.Size(75, 75);
            this.pictureBox_disgust.TabIndex = 6;
            this.pictureBox_disgust.TabStop = false;
            // 
            // pictureBox_sad
            // 
            this.pictureBox_sad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_sad.BackgroundImage")));
            this.pictureBox_sad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_sad.Location = new System.Drawing.Point(840, 203);
            this.pictureBox_sad.Name = "pictureBox_sad";
            this.pictureBox_sad.Size = new System.Drawing.Size(75, 75);
            this.pictureBox_sad.TabIndex = 7;
            this.pictureBox_sad.TabStop = false;
            // 
            // pictureBox_confidence
            // 
            this.pictureBox_confidence.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_confidence.BackgroundImage")));
            this.pictureBox_confidence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_confidence.Location = new System.Drawing.Point(840, 446);
            this.pictureBox_confidence.Name = "pictureBox_confidence";
            this.pictureBox_confidence.Size = new System.Drawing.Size(75, 75);
            this.pictureBox_confidence.TabIndex = 8;
            this.pictureBox_confidence.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Translation :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(25, 300);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.richTextBox1.Size = new System.Drawing.Size(800, 230);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // textBox_translation
            // 
            this.textBox_translation.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_translation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_translation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_translation.Location = new System.Drawing.Point(35, 309);
            this.textBox_translation.Multiline = true;
            this.textBox_translation.Name = "textBox_translation";
            this.textBox_translation.Size = new System.Drawing.Size(780, 210);
            this.textBox_translation.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(25, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 230);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(25, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 230);
            this.panel2.TabIndex = 19;
            // 
            // button_saveToFile
            // 
            this.button_saveToFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.button_saveToFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_saveToFile.FlatAppearance.BorderSize = 0;
            this.button_saveToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_saveToFile.ForeColor = System.Drawing.Color.Transparent;
            this.button_saveToFile.Image = ((System.Drawing.Image)(resources.GetObject("button_saveToFile.Image")));
            this.button_saveToFile.Location = new System.Drawing.Point(765, 264);
            this.button_saveToFile.Name = "button_saveToFile";
            this.button_saveToFile.Size = new System.Drawing.Size(60, 33);
            this.button_saveToFile.TabIndex = 20;
            this.button_saveToFile.UseVisualStyleBackColor = false;
            this.button_saveToFile.Click += new System.EventHandler(this.button_saveToFile_Click);
            // 
            // label_happy
            // 
            this.label_happy.AutoSize = true;
            this.label_happy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_happy.Location = new System.Drawing.Point(921, 65);
            this.label_happy.Name = "label_happy";
            this.label_happy.Size = new System.Drawing.Size(36, 20);
            this.label_happy.TabIndex = 21;
            this.label_happy.Text = "0 %";
            // 
            // label_angry
            // 
            this.label_angry.AutoSize = true;
            this.label_angry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_angry.Location = new System.Drawing.Point(921, 150);
            this.label_angry.Name = "label_angry";
            this.label_angry.Size = new System.Drawing.Size(36, 20);
            this.label_angry.TabIndex = 22;
            this.label_angry.Text = "0 %";
            // 
            // label_sad
            // 
            this.label_sad.AutoSize = true;
            this.label_sad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sad.Location = new System.Drawing.Point(921, 225);
            this.label_sad.Name = "label_sad";
            this.label_sad.Size = new System.Drawing.Size(36, 20);
            this.label_sad.TabIndex = 23;
            this.label_sad.Text = "0 %";
            // 
            // label_disgust
            // 
            this.label_disgust.AutoSize = true;
            this.label_disgust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_disgust.Location = new System.Drawing.Point(921, 313);
            this.label_disgust.Name = "label_disgust";
            this.label_disgust.Size = new System.Drawing.Size(36, 20);
            this.label_disgust.TabIndex = 24;
            this.label_disgust.Text = "0 %";
            // 
            // label_fear
            // 
            this.label_fear.AutoSize = true;
            this.label_fear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fear.Location = new System.Drawing.Point(921, 393);
            this.label_fear.Name = "label_fear";
            this.label_fear.Size = new System.Drawing.Size(36, 20);
            this.label_fear.TabIndex = 25;
            this.label_fear.Text = "0 %";
            // 
            // label_confidence
            // 
            this.label_confidence.AutoSize = true;
            this.label_confidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_confidence.Location = new System.Drawing.Point(921, 475);
            this.label_confidence.Name = "label_confidence";
            this.label_confidence.Size = new System.Drawing.Size(36, 20);
            this.label_confidence.TabIndex = 26;
            this.label_confidence.Text = "0 %";
            // 
            // SummaryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.label_confidence);
            this.Controls.Add(this.label_fear);
            this.Controls.Add(this.label_disgust);
            this.Controls.Add(this.label_sad);
            this.Controls.Add(this.label_angry);
            this.Controls.Add(this.label_happy);
            this.Controls.Add(this.button_saveToFile);
            this.Controls.Add(this.textBox_translation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox_confidence);
            this.Controls.Add(this.pictureBox_sad);
            this.Controls.Add(this.pictureBox_disgust);
            this.Controls.Add(this.pictureBox_fear);
            this.Controls.Add(this.pictureBox_anger);
            this.Controls.Add(this.pictureBox_happy);
            this.Controls.Add(this.richTextBox_summary);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "SummaryPanel";
            this.Size = new System.Drawing.Size(1000, 560);
            this.Load += new System.EventHandler(this.SummaryPanel_Load);
            this.VisibleChanged += new System.EventHandler(this.SummaryPanel_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_happy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_anger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_disgust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_confidence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_summary;
        private System.Windows.Forms.PictureBox pictureBox_happy;
        private System.Windows.Forms.PictureBox pictureBox_anger;
        private System.Windows.Forms.PictureBox pictureBox_fear;
        private System.Windows.Forms.PictureBox pictureBox_disgust;
        private System.Windows.Forms.PictureBox pictureBox_sad;
        private System.Windows.Forms.PictureBox pictureBox_confidence;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.TextBox textBox_translation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_saveToFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label_happy;
        private System.Windows.Forms.Label label_angry;
        private System.Windows.Forms.Label label_sad;
        private System.Windows.Forms.Label label_disgust;
        private System.Windows.Forms.Label label_fear;
        private System.Windows.Forms.Label label_confidence;
    }
}
