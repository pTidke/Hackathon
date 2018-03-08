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
            this.bunifuCircleProgressbar_happy = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar_confidence = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar_fear = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar_disgust = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar_sad = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar_anger = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.richTextBox_summary.Location = new System.Drawing.Point(38, 38);
            this.richTextBox_summary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox_summary.Name = "richTextBox_summary";
            this.richTextBox_summary.ReadOnly = true;
            this.richTextBox_summary.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.richTextBox_summary.Size = new System.Drawing.Size(1200, 354);
            this.richTextBox_summary.TabIndex = 0;
            this.richTextBox_summary.Text = "";
            // 
            // pictureBox_happy
            // 
            this.pictureBox_happy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_happy.BackgroundImage")));
            this.pictureBox_happy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_happy.Location = new System.Drawing.Point(1260, 63);
            this.pictureBox_happy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_happy.Name = "pictureBox_happy";
            this.pictureBox_happy.Size = new System.Drawing.Size(112, 115);
            this.pictureBox_happy.TabIndex = 3;
            this.pictureBox_happy.TabStop = false;
            // 
            // pictureBox_anger
            // 
            this.pictureBox_anger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_anger.BackgroundImage")));
            this.pictureBox_anger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_anger.Location = new System.Drawing.Point(1260, 188);
            this.pictureBox_anger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_anger.Name = "pictureBox_anger";
            this.pictureBox_anger.Size = new System.Drawing.Size(112, 115);
            this.pictureBox_anger.TabIndex = 4;
            this.pictureBox_anger.TabStop = false;
            // 
            // pictureBox_fear
            // 
            this.pictureBox_fear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_fear.BackgroundImage")));
            this.pictureBox_fear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_fear.Location = new System.Drawing.Point(1260, 562);
            this.pictureBox_fear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_fear.Name = "pictureBox_fear";
            this.pictureBox_fear.Size = new System.Drawing.Size(112, 115);
            this.pictureBox_fear.TabIndex = 5;
            this.pictureBox_fear.TabStop = false;
            // 
            // pictureBox_disgust
            // 
            this.pictureBox_disgust.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_disgust.BackgroundImage")));
            this.pictureBox_disgust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_disgust.Location = new System.Drawing.Point(1260, 437);
            this.pictureBox_disgust.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_disgust.Name = "pictureBox_disgust";
            this.pictureBox_disgust.Size = new System.Drawing.Size(112, 115);
            this.pictureBox_disgust.TabIndex = 6;
            this.pictureBox_disgust.TabStop = false;
            // 
            // pictureBox_sad
            // 
            this.pictureBox_sad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_sad.BackgroundImage")));
            this.pictureBox_sad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_sad.Location = new System.Drawing.Point(1260, 312);
            this.pictureBox_sad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_sad.Name = "pictureBox_sad";
            this.pictureBox_sad.Size = new System.Drawing.Size(112, 115);
            this.pictureBox_sad.TabIndex = 7;
            this.pictureBox_sad.TabStop = false;
            // 
            // pictureBox_confidence
            // 
            this.pictureBox_confidence.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_confidence.BackgroundImage")));
            this.pictureBox_confidence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_confidence.Location = new System.Drawing.Point(1260, 686);
            this.pictureBox_confidence.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_confidence.Name = "pictureBox_confidence";
            this.pictureBox_confidence.Size = new System.Drawing.Size(112, 115);
            this.pictureBox_confidence.TabIndex = 8;
            this.pictureBox_confidence.TabStop = false;
            // 
            // bunifuCircleProgressbar_happy
            // 
            this.bunifuCircleProgressbar_happy.animated = false;
            this.bunifuCircleProgressbar_happy.animationIterval = 5;
            this.bunifuCircleProgressbar_happy.animationSpeed = 300;
            this.bunifuCircleProgressbar_happy.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar_happy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar_happy.BackgroundImage")));
            this.bunifuCircleProgressbar_happy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuCircleProgressbar_happy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCircleProgressbar_happy.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar_happy.LabelVisible = true;
            this.bunifuCircleProgressbar_happy.LineProgressThickness = 8;
            this.bunifuCircleProgressbar_happy.LineThickness = 5;
            this.bunifuCircleProgressbar_happy.Location = new System.Drawing.Point(1382, 63);
            this.bunifuCircleProgressbar_happy.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bunifuCircleProgressbar_happy.MaxValue = 100;
            this.bunifuCircleProgressbar_happy.Name = "bunifuCircleProgressbar_happy";
            this.bunifuCircleProgressbar_happy.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar_happy.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar_happy.Size = new System.Drawing.Size(115, 115);
            this.bunifuCircleProgressbar_happy.TabIndex = 9;
            this.bunifuCircleProgressbar_happy.Value = 0;
            // 
            // bunifuCircleProgressbar_confidence
            // 
            this.bunifuCircleProgressbar_confidence.animated = false;
            this.bunifuCircleProgressbar_confidence.animationIterval = 5;
            this.bunifuCircleProgressbar_confidence.animationSpeed = 300;
            this.bunifuCircleProgressbar_confidence.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar_confidence.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar_confidence.BackgroundImage")));
            this.bunifuCircleProgressbar_confidence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuCircleProgressbar_confidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCircleProgressbar_confidence.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar_confidence.LabelVisible = true;
            this.bunifuCircleProgressbar_confidence.LineProgressThickness = 8;
            this.bunifuCircleProgressbar_confidence.LineThickness = 5;
            this.bunifuCircleProgressbar_confidence.Location = new System.Drawing.Point(1382, 686);
            this.bunifuCircleProgressbar_confidence.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bunifuCircleProgressbar_confidence.MaxValue = 100;
            this.bunifuCircleProgressbar_confidence.Name = "bunifuCircleProgressbar_confidence";
            this.bunifuCircleProgressbar_confidence.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar_confidence.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar_confidence.Size = new System.Drawing.Size(115, 115);
            this.bunifuCircleProgressbar_confidence.TabIndex = 10;
            this.bunifuCircleProgressbar_confidence.Value = 0;
            // 
            // bunifuCircleProgressbar_fear
            // 
            this.bunifuCircleProgressbar_fear.animated = false;
            this.bunifuCircleProgressbar_fear.animationIterval = 5;
            this.bunifuCircleProgressbar_fear.animationSpeed = 300;
            this.bunifuCircleProgressbar_fear.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar_fear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar_fear.BackgroundImage")));
            this.bunifuCircleProgressbar_fear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuCircleProgressbar_fear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCircleProgressbar_fear.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar_fear.LabelVisible = true;
            this.bunifuCircleProgressbar_fear.LineProgressThickness = 8;
            this.bunifuCircleProgressbar_fear.LineThickness = 5;
            this.bunifuCircleProgressbar_fear.Location = new System.Drawing.Point(1382, 562);
            this.bunifuCircleProgressbar_fear.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bunifuCircleProgressbar_fear.MaxValue = 100;
            this.bunifuCircleProgressbar_fear.Name = "bunifuCircleProgressbar_fear";
            this.bunifuCircleProgressbar_fear.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar_fear.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar_fear.Size = new System.Drawing.Size(115, 115);
            this.bunifuCircleProgressbar_fear.TabIndex = 11;
            this.bunifuCircleProgressbar_fear.Value = 0;
            // 
            // bunifuCircleProgressbar_disgust
            // 
            this.bunifuCircleProgressbar_disgust.animated = false;
            this.bunifuCircleProgressbar_disgust.animationIterval = 5;
            this.bunifuCircleProgressbar_disgust.animationSpeed = 300;
            this.bunifuCircleProgressbar_disgust.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar_disgust.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar_disgust.BackgroundImage")));
            this.bunifuCircleProgressbar_disgust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuCircleProgressbar_disgust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCircleProgressbar_disgust.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar_disgust.LabelVisible = true;
            this.bunifuCircleProgressbar_disgust.LineProgressThickness = 8;
            this.bunifuCircleProgressbar_disgust.LineThickness = 5;
            this.bunifuCircleProgressbar_disgust.Location = new System.Drawing.Point(1383, 437);
            this.bunifuCircleProgressbar_disgust.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bunifuCircleProgressbar_disgust.MaxValue = 100;
            this.bunifuCircleProgressbar_disgust.Name = "bunifuCircleProgressbar_disgust";
            this.bunifuCircleProgressbar_disgust.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar_disgust.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar_disgust.Size = new System.Drawing.Size(115, 115);
            this.bunifuCircleProgressbar_disgust.TabIndex = 12;
            this.bunifuCircleProgressbar_disgust.Value = 0;
            // 
            // bunifuCircleProgressbar_sad
            // 
            this.bunifuCircleProgressbar_sad.animated = false;
            this.bunifuCircleProgressbar_sad.animationIterval = 5;
            this.bunifuCircleProgressbar_sad.animationSpeed = 300;
            this.bunifuCircleProgressbar_sad.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar_sad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar_sad.BackgroundImage")));
            this.bunifuCircleProgressbar_sad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuCircleProgressbar_sad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCircleProgressbar_sad.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar_sad.LabelVisible = true;
            this.bunifuCircleProgressbar_sad.LineProgressThickness = 8;
            this.bunifuCircleProgressbar_sad.LineThickness = 5;
            this.bunifuCircleProgressbar_sad.Location = new System.Drawing.Point(1382, 312);
            this.bunifuCircleProgressbar_sad.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bunifuCircleProgressbar_sad.MaxValue = 100;
            this.bunifuCircleProgressbar_sad.Name = "bunifuCircleProgressbar_sad";
            this.bunifuCircleProgressbar_sad.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar_sad.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar_sad.Size = new System.Drawing.Size(115, 115);
            this.bunifuCircleProgressbar_sad.TabIndex = 13;
            this.bunifuCircleProgressbar_sad.Value = 0;
            // 
            // bunifuCircleProgressbar_anger
            // 
            this.bunifuCircleProgressbar_anger.animated = false;
            this.bunifuCircleProgressbar_anger.animationIterval = 5;
            this.bunifuCircleProgressbar_anger.animationSpeed = 300;
            this.bunifuCircleProgressbar_anger.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar_anger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar_anger.BackgroundImage")));
            this.bunifuCircleProgressbar_anger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuCircleProgressbar_anger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCircleProgressbar_anger.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar_anger.LabelVisible = true;
            this.bunifuCircleProgressbar_anger.LineProgressThickness = 8;
            this.bunifuCircleProgressbar_anger.LineThickness = 5;
            this.bunifuCircleProgressbar_anger.Location = new System.Drawing.Point(1383, 188);
            this.bunifuCircleProgressbar_anger.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bunifuCircleProgressbar_anger.MaxValue = 100;
            this.bunifuCircleProgressbar_anger.Name = "bunifuCircleProgressbar_anger";
            this.bunifuCircleProgressbar_anger.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar_anger.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar_anger.Size = new System.Drawing.Size(115, 115);
            this.bunifuCircleProgressbar_anger.TabIndex = 14;
            this.bunifuCircleProgressbar_anger.Value = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(38, 462);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.richTextBox1.Size = new System.Drawing.Size(1200, 354);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 423);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 34);
            this.label1.TabIndex = 16;
            this.label1.Text = "Translation :";
            // 
            // SummaryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bunifuCircleProgressbar_anger);
            this.Controls.Add(this.bunifuCircleProgressbar_sad);
            this.Controls.Add(this.bunifuCircleProgressbar_disgust);
            this.Controls.Add(this.bunifuCircleProgressbar_fear);
            this.Controls.Add(this.bunifuCircleProgressbar_confidence);
            this.Controls.Add(this.bunifuCircleProgressbar_happy);
            this.Controls.Add(this.pictureBox_confidence);
            this.Controls.Add(this.pictureBox_sad);
            this.Controls.Add(this.pictureBox_disgust);
            this.Controls.Add(this.pictureBox_fear);
            this.Controls.Add(this.pictureBox_anger);
            this.Controls.Add(this.pictureBox_happy);
            this.Controls.Add(this.richTextBox_summary);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SummaryPanel";
            this.Size = new System.Drawing.Size(1500, 862);
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
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar_happy;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar_confidence;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar_fear;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar_disgust;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar_sad;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar_anger;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}
