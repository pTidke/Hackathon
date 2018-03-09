namespace SpeechToText
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_language = new System.Windows.Forms.Panel();
            this.button_teluguLanguage = new System.Windows.Forms.Button();
            this.button_tamilLanguage = new System.Windows.Forms.Button();
            this.button_hindiLanguage = new System.Windows.Forms.Button();
            this.button_upload = new System.Windows.Forms.Button();
            this.button_language = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_record = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.summaryPanel1 = new SpeechToText.SummaryPanel();
            this.label_listening = new System.Windows.Forms.Label();
            this.recordingPanel1 = new SpeechToText.RecordingPanel();
            this.uplaodingPanel1 = new SpeechToText.UplaodingPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_language.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.panelHeader.Controls.Add(this.button2);
            this.panelHeader.Controls.Add(this.button);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(100, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 40);
            this.panelHeader.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(920, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button
            // 
            this.button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button.Dock = System.Windows.Forms.DockStyle.Right;
            this.button.FlatAppearance.BorderSize = 0;
            this.button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Image = ((System.Drawing.Image)(resources.GetObject("button.Image")));
            this.button.Location = new System.Drawing.Point(960, 0);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(40, 40);
            this.button.TabIndex = 0;
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel_language);
            this.panel1.Controls.Add(this.button_upload);
            this.panel1.Controls.Add(this.button_language);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.button_record);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 600);
            this.panel1.TabIndex = 0;
            // 
            // panel_language
            // 
            this.panel_language.Controls.Add(this.button_teluguLanguage);
            this.panel_language.Controls.Add(this.button_tamilLanguage);
            this.panel_language.Controls.Add(this.button_hindiLanguage);
            this.panel_language.Location = new System.Drawing.Point(0, 359);
            this.panel_language.Name = "panel_language";
            this.panel_language.Size = new System.Drawing.Size(100, 100);
            this.panel_language.TabIndex = 5;
            this.panel_language.Visible = false;
            // 
            // button_teluguLanguage
            // 
            this.button_teluguLanguage.FlatAppearance.BorderSize = 0;
            this.button_teluguLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_teluguLanguage.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_teluguLanguage.ForeColor = System.Drawing.Color.Transparent;
            this.button_teluguLanguage.Location = new System.Drawing.Point(0, 70);
            this.button_teluguLanguage.Name = "button_teluguLanguage";
            this.button_teluguLanguage.Size = new System.Drawing.Size(100, 30);
            this.button_teluguLanguage.TabIndex = 2;
            this.button_teluguLanguage.Text = "Telugu";
            this.button_teluguLanguage.UseVisualStyleBackColor = true;
            this.button_teluguLanguage.Click += new System.EventHandler(this.button_teluguLanguage_Click);
            // 
            // button_tamilLanguage
            // 
            this.button_tamilLanguage.FlatAppearance.BorderSize = 0;
            this.button_tamilLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tamilLanguage.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tamilLanguage.ForeColor = System.Drawing.Color.Transparent;
            this.button_tamilLanguage.Location = new System.Drawing.Point(0, 39);
            this.button_tamilLanguage.Name = "button_tamilLanguage";
            this.button_tamilLanguage.Size = new System.Drawing.Size(100, 30);
            this.button_tamilLanguage.TabIndex = 1;
            this.button_tamilLanguage.Text = "Tamil";
            this.button_tamilLanguage.UseVisualStyleBackColor = true;
            this.button_tamilLanguage.Click += new System.EventHandler(this.button_tamilLanguage_Click);
            // 
            // button_hindiLanguage
            // 
            this.button_hindiLanguage.FlatAppearance.BorderSize = 0;
            this.button_hindiLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hindiLanguage.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hindiLanguage.ForeColor = System.Drawing.Color.Transparent;
            this.button_hindiLanguage.Location = new System.Drawing.Point(0, 3);
            this.button_hindiLanguage.Name = "button_hindiLanguage";
            this.button_hindiLanguage.Size = new System.Drawing.Size(100, 30);
            this.button_hindiLanguage.TabIndex = 0;
            this.button_hindiLanguage.Text = "Hindi";
            this.button_hindiLanguage.UseVisualStyleBackColor = true;
            this.button_hindiLanguage.Click += new System.EventHandler(this.button_hindiLanguage_Click);
            // 
            // button_upload
            // 
            this.button_upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_upload.FlatAppearance.BorderSize = 0;
            this.button_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_upload.Image = ((System.Drawing.Image)(resources.GetObject("button_upload.Image")));
            this.button_upload.Location = new System.Drawing.Point(0, 200);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(100, 100);
            this.button_upload.TabIndex = 4;
            this.button_upload.UseVisualStyleBackColor = true;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // button_language
            // 
            this.button_language.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_language.FlatAppearance.BorderSize = 0;
            this.button_language.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_language.Image = ((System.Drawing.Image)(resources.GetObject("button_language.Image")));
            this.button_language.Location = new System.Drawing.Point(0, 465);
            this.button_language.Name = "button_language";
            this.button_language.Size = new System.Drawing.Size(100, 100);
            this.button_language.TabIndex = 3;
            this.button_language.UseVisualStyleBackColor = true;
            this.button_language.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 100);
            this.panel4.TabIndex = 2;
            // 
            // button_record
            // 
            this.button_record.FlatAppearance.BorderSize = 0;
            this.button_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_record.Image = ((System.Drawing.Image)(resources.GetObject("button_record.Image")));
            this.button_record.Location = new System.Drawing.Point(0, 100);
            this.button_record.Name = "button_record";
            this.button_record.Size = new System.Drawing.Size(100, 100);
            this.button_record.TabIndex = 0;
            this.button_record.UseVisualStyleBackColor = true;
            this.button_record.Click += new System.EventHandler(this.button_record_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.panel3.Controls.Add(this.summaryPanel1);
            this.panel3.Controls.Add(this.label_listening);
            this.panel3.Controls.Add(this.recordingPanel1);
            this.panel3.Controls.Add(this.uplaodingPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(100, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 560);
            this.panel3.TabIndex = 2;
            // 
            // summaryPanel1
            // 
            this.summaryPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.summaryPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryPanel1.Location = new System.Drawing.Point(0, 0);
            this.summaryPanel1.Name = "summaryPanel1";
            this.summaryPanel1.Size = new System.Drawing.Size(1000, 560);
            this.summaryPanel1.TabIndex = 2;
            this.summaryPanel1.Visible = false;
            // 
            // label_listening
            // 
            this.label_listening.AutoSize = true;
            this.label_listening.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_listening.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.label_listening.Location = new System.Drawing.Point(6, 527);
            this.label_listening.Name = "label_listening";
            this.label_listening.Size = new System.Drawing.Size(100, 24);
            this.label_listening.TabIndex = 0;
            this.label_listening.Text = "Listening...";
            this.label_listening.Visible = false;
            // 
            // recordingPanel1
            // 
            this.recordingPanel1.AllowDrop = true;
            this.recordingPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.recordingPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordingPanel1.Location = new System.Drawing.Point(0, 0);
            this.recordingPanel1.Name = "recordingPanel1";
            this.recordingPanel1.Size = new System.Drawing.Size(1000, 560);
            this.recordingPanel1.TabIndex = 1;
            this.recordingPanel1.Visible = false;
            // 
            // uplaodingPanel1
            // 
            this.uplaodingPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.uplaodingPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uplaodingPanel1.Location = new System.Drawing.Point(0, 0);
            this.uplaodingPanel1.Name = "uplaodingPanel1";
            this.uplaodingPanel1.Size = new System.Drawing.Size(1000, 560);
            this.uplaodingPanel1.TabIndex = 3;
            this.uplaodingPanel1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(25, 570);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "OFF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_language.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_record;
        private System.Windows.Forms.Label label_listening;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.Button button_language;
        public RecordingPanel recordingPanel1{ get; set; }
    public UplaodingPanel uplaodingPanel1{ get; set; }
    public SummaryPanel summaryPanel1 { get; set; }
        private System.Windows.Forms.Panel panel_language;
        private System.Windows.Forms.Button button_teluguLanguage;
        private System.Windows.Forms.Button button_tamilLanguage;
        private System.Windows.Forms.Button button_hindiLanguage;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
    }
}

