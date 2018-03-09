namespace SpeechToText
{
    partial class RecordingPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordingPanel));
            this.textBox_FinalResponse = new System.Windows.Forms.TextBox();
            this.textBox_interimResponse = new System.Windows.Forms.TextBox();
            this.label_listening = new System.Windows.Forms.Label();
            this.button_startStopToggle = new System.Windows.Forms.Button();
            this.label_log = new System.Windows.Forms.Label();
            this.textBox_interimTranslated = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textBox_FinalResponse
            // 
            this.textBox_FinalResponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_FinalResponse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_FinalResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FinalResponse.Location = new System.Drawing.Point(35, 35);
            this.textBox_FinalResponse.Margin = new System.Windows.Forms.Padding(25);
            this.textBox_FinalResponse.Multiline = true;
            this.textBox_FinalResponse.Name = "textBox_FinalResponse";
            this.textBox_FinalResponse.Size = new System.Drawing.Size(930, 420);
            this.textBox_FinalResponse.TabIndex = 0;
            // 
            // textBox_interimResponse
            // 
            this.textBox_interimResponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.textBox_interimResponse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_interimResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_interimResponse.Location = new System.Drawing.Point(500, 482);
            this.textBox_interimResponse.Name = "textBox_interimResponse";
            this.textBox_interimResponse.Size = new System.Drawing.Size(475, 30);
            this.textBox_interimResponse.TabIndex = 1;
            // 
            // label_listening
            // 
            this.label_listening.AutoSize = true;
            this.label_listening.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_listening.ForeColor = System.Drawing.Color.Green;
            this.label_listening.Location = new System.Drawing.Point(20, 517);
            this.label_listening.Name = "label_listening";
            this.label_listening.Size = new System.Drawing.Size(131, 26);
            this.label_listening.TabIndex = 2;
            this.label_listening.Text = "Listening ...";
            this.label_listening.Visible = false;
            // 
            // button_startStopToggle
            // 
            this.button_startStopToggle.BackColor = System.Drawing.Color.Transparent;
            this.button_startStopToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_startStopToggle.FlatAppearance.BorderSize = 0;
            this.button_startStopToggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.button_startStopToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_startStopToggle.Image = ((System.Drawing.Image)(resources.GetObject("button_startStopToggle.Image")));
            this.button_startStopToggle.Location = new System.Drawing.Point(454, 473);
            this.button_startStopToggle.Name = "button_startStopToggle";
            this.button_startStopToggle.Size = new System.Drawing.Size(40, 40);
            this.button_startStopToggle.TabIndex = 3;
            this.button_startStopToggle.UseVisualStyleBackColor = false;
            this.button_startStopToggle.Click += new System.EventHandler(this.button_startStopToggle_Click);
            this.button_startStopToggle.MouseLeave += new System.EventHandler(this.button_startStopToggle_MouseLeave);
            // 
            // label_log
            // 
            this.label_log.AutoSize = true;
            this.label_log.Location = new System.Drawing.Point(22, 473);
            this.label_log.Name = "label_log";
            this.label_log.Size = new System.Drawing.Size(35, 13);
            this.label_log.TabIndex = 4;
            this.label_log.Text = "label1";
            // 
            // textBox_interimTranslated
            // 
            this.textBox_interimTranslated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.textBox_interimTranslated.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_interimTranslated.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_interimTranslated.Location = new System.Drawing.Point(500, 520);
            this.textBox_interimTranslated.Name = "textBox_interimTranslated";
            this.textBox_interimTranslated.Size = new System.Drawing.Size(475, 23);
            this.textBox_interimTranslated.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(25, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 440);
            this.panel1.TabIndex = 6;
            // 
            // RecordingPanel
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.textBox_interimTranslated);
            this.Controls.Add(this.label_log);
            this.Controls.Add(this.button_startStopToggle);
            this.Controls.Add(this.label_listening);
            this.Controls.Add(this.textBox_interimResponse);
            this.Controls.Add(this.textBox_FinalResponse);
            this.Controls.Add(this.panel1);
            this.Name = "RecordingPanel";
            this.Size = new System.Drawing.Size(1000, 560);
            this.VisibleChanged += new System.EventHandler(this.RecordingPanel_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_FinalResponse;
        private System.Windows.Forms.TextBox textBox_interimResponse;
        private System.Windows.Forms.Label label_listening;
        private System.Windows.Forms.Button button_startStopToggle;
        private System.Windows.Forms.Label label_log;
        private System.Windows.Forms.TextBox textBox_interimTranslated;
        private System.Windows.Forms.Panel panel1;
    }
}
