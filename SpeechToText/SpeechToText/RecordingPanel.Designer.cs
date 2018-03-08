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
            this.textBox_FinalResponse = new System.Windows.Forms.TextBox();
            this.textBox_interimResponse = new System.Windows.Forms.TextBox();
            this.label_listening = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_FinalResponse
            // 
            this.textBox_FinalResponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_FinalResponse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_FinalResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FinalResponse.Location = new System.Drawing.Point(25, 25);
            this.textBox_FinalResponse.Margin = new System.Windows.Forms.Padding(25);
            this.textBox_FinalResponse.Multiline = true;
            this.textBox_FinalResponse.Name = "textBox_FinalResponse";
            this.textBox_FinalResponse.Size = new System.Drawing.Size(950, 450);
            this.textBox_FinalResponse.TabIndex = 0;
            // 
            // textBox_interimResponse
            // 
            this.textBox_interimResponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.textBox_interimResponse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_interimResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_interimResponse.Location = new System.Drawing.Point(500, 500);
            this.textBox_interimResponse.Name = "textBox_interimResponse";
            this.textBox_interimResponse.Size = new System.Drawing.Size(475, 30);
            this.textBox_interimResponse.TabIndex = 1;
            // 
            // label_listening
            // 
            this.label_listening.AutoSize = true;
            this.label_listening.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_listening.ForeColor = System.Drawing.Color.Green;
            this.label_listening.Location = new System.Drawing.Point(25, 500);
            this.label_listening.Name = "label_listening";
            this.label_listening.Size = new System.Drawing.Size(131, 26);
            this.label_listening.TabIndex = 2;
            this.label_listening.Text = "Listening ...";
            // 
            // RecordingPanel
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.label_listening);
            this.Controls.Add(this.textBox_interimResponse);
            this.Controls.Add(this.textBox_FinalResponse);
            this.Name = "RecordingPanel";
            this.Size = new System.Drawing.Size(1000, 560);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_FinalResponse;
        private System.Windows.Forms.TextBox textBox_interimResponse;
        private System.Windows.Forms.Label label_listening;
    }
}
