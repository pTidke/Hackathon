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
            this.uplaodingPanel1 = new SpeechToText.UplaodingPanel();
            this.summaryPanel1 = new SpeechToText.SummaryPanel();
            this.recordingPanel1 = new SpeechToText.RecordingPanel();
            this.label_listening = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.panelHeader.Location = new System.Drawing.Point(150, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1500, 62);
            this.panelHeader.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1380, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 62);
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
            this.button.Location = new System.Drawing.Point(1440, 0);
            this.button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(60, 62);
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
            this.panel1.Controls.Add(this.panel_language);
            this.panel1.Controls.Add(this.button_upload);
            this.panel1.Controls.Add(this.button_language);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.button_record);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 923);
            this.panel1.TabIndex = 0;
            // 
            // panel_language
            // 
            this.panel_language.Controls.Add(this.button_teluguLanguage);
            this.panel_language.Controls.Add(this.button_tamilLanguage);
            this.panel_language.Controls.Add(this.button_hindiLanguage);
            this.panel_language.Location = new System.Drawing.Point(0, 606);
            this.panel_language.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_language.Name = "panel_language";
            this.panel_language.Size = new System.Drawing.Size(150, 154);
            this.panel_language.TabIndex = 5;
            this.panel_language.Visible = false;
            // 
            // button_teluguLanguage
            // 
            this.button_teluguLanguage.FlatAppearance.BorderSize = 0;
            this.button_teluguLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_teluguLanguage.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_teluguLanguage.ForeColor = System.Drawing.Color.Transparent;
            this.button_teluguLanguage.Location = new System.Drawing.Point(0, 108);
            this.button_teluguLanguage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_teluguLanguage.Name = "button_teluguLanguage";
            this.button_teluguLanguage.Size = new System.Drawing.Size(150, 46);
            this.button_teluguLanguage.TabIndex = 2;
            this.button_teluguLanguage.Text = "Telugu";
            this.button_teluguLanguage.UseVisualStyleBackColor = true;
            // 
            // button_tamilLanguage
            // 
            this.button_tamilLanguage.FlatAppearance.BorderSize = 0;
            this.button_tamilLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tamilLanguage.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tamilLanguage.ForeColor = System.Drawing.Color.Transparent;
            this.button_tamilLanguage.Location = new System.Drawing.Point(0, 60);
            this.button_tamilLanguage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_tamilLanguage.Name = "button_tamilLanguage";
            this.button_tamilLanguage.Size = new System.Drawing.Size(150, 46);
            this.button_tamilLanguage.TabIndex = 1;
            this.button_tamilLanguage.Text = "Tamil";
            this.button_tamilLanguage.UseVisualStyleBackColor = true;
            // 
            // button_hindiLanguage
            // 
            this.button_hindiLanguage.FlatAppearance.BorderSize = 0;
            this.button_hindiLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hindiLanguage.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hindiLanguage.ForeColor = System.Drawing.Color.Transparent;
            this.button_hindiLanguage.Location = new System.Drawing.Point(0, 5);
            this.button_hindiLanguage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_hindiLanguage.Name = "button_hindiLanguage";
            this.button_hindiLanguage.Size = new System.Drawing.Size(150, 46);
            this.button_hindiLanguage.TabIndex = 0;
            this.button_hindiLanguage.Text = "Hindi";
            this.button_hindiLanguage.UseVisualStyleBackColor = true;
            // 
            // button_upload
            // 
            this.button_upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_upload.FlatAppearance.BorderSize = 0;
            this.button_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_upload.Image = ((System.Drawing.Image)(resources.GetObject("button_upload.Image")));
            this.button_upload.Location = new System.Drawing.Point(0, 308);
            this.button_upload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(150, 154);
            this.button_upload.TabIndex = 4;
            this.button_upload.UseVisualStyleBackColor = true;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // button_language
            // 
            this.button_language.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_language.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_language.FlatAppearance.BorderSize = 0;
            this.button_language.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_language.Image = ((System.Drawing.Image)(resources.GetObject("button_language.Image")));
            this.button_language.Location = new System.Drawing.Point(0, 769);
            this.button_language.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_language.Name = "button_language";
            this.button_language.Size = new System.Drawing.Size(150, 154);
            this.button_language.TabIndex = 3;
            this.button_language.UseVisualStyleBackColor = true;
            this.button_language.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 154);
            this.panel4.TabIndex = 2;
            // 
            // button_record
            // 
            this.button_record.FlatAppearance.BorderSize = 0;
            this.button_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_record.Image = ((System.Drawing.Image)(resources.GetObject("button_record.Image")));
            this.button_record.Location = new System.Drawing.Point(0, 154);
            this.button_record.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_record.Name = "button_record";
            this.button_record.Size = new System.Drawing.Size(150, 154);
            this.button_record.TabIndex = 0;
            this.button_record.UseVisualStyleBackColor = true;
            this.button_record.Click += new System.EventHandler(this.button_record_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.panel3.Controls.Add(this.uplaodingPanel1);
            this.panel3.Controls.Add(this.summaryPanel1);
            this.panel3.Controls.Add(this.recordingPanel1);
            this.panel3.Controls.Add(this.label_listening);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(150, 62);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1500, 861);
            this.panel3.TabIndex = 2;
            // 
            // uplaodingPanel1
            // 
            this.uplaodingPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.uplaodingPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uplaodingPanel1.Location = new System.Drawing.Point(0, 0);
            this.uplaodingPanel1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.uplaodingPanel1.Name = "uplaodingPanel1";
            this.uplaodingPanel1.Size = new System.Drawing.Size(1500, 861);
            this.uplaodingPanel1.TabIndex = 3;
            this.uplaodingPanel1.Visible = false;
            // 
            // summaryPanel1
            // 
            this.summaryPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.summaryPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryPanel1.Location = new System.Drawing.Point(0, 0);
            this.summaryPanel1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.summaryPanel1.Name = "summaryPanel1";
            this.summaryPanel1.Size = new System.Drawing.Size(1500, 861);
            this.summaryPanel1.TabIndex = 2;
            this.summaryPanel1.Visible = false;
            // 
            // recordingPanel1
            // 
            this.recordingPanel1.AllowDrop = true;
            this.recordingPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.recordingPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordingPanel1.Location = new System.Drawing.Point(0, 0);
            this.recordingPanel1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.recordingPanel1.Name = "recordingPanel1";
            this.recordingPanel1.Size = new System.Drawing.Size(1500, 861);
            this.recordingPanel1.TabIndex = 1;
            this.recordingPanel1.Visible = false;
            // 
            // label_listening
            // 
            this.label_listening.AutoSize = true;
            this.label_listening.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_listening.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.label_listening.Location = new System.Drawing.Point(9, 811);
            this.label_listening.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_listening.Name = "label_listening";
            this.label_listening.Size = new System.Drawing.Size(156, 33);
            this.label_listening.TabIndex = 0;
            this.label_listening.Text = "Listening...";
            this.label_listening.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1650, 923);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private RecordingPanel recordingPanel1;
        private UplaodingPanel uplaodingPanel1;
        private SummaryPanel summaryPanel1;
        private System.Windows.Forms.Panel panel_language;
        private System.Windows.Forms.Button button_teluguLanguage;
        private System.Windows.Forms.Button button_tamilLanguage;
        private System.Windows.Forms.Button button_hindiLanguage;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

