namespace VoiceChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StopTalkingBTN = new System.Windows.Forms.Button();
            this.ServerIPTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartTalkingBTN = new System.Windows.Forms.Button();
            this.JoinBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StopTalkingBTN
            // 
            this.StopTalkingBTN.Enabled = false;
            this.StopTalkingBTN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopTalkingBTN.Location = new System.Drawing.Point(73, 202);
            this.StopTalkingBTN.Name = "StopTalkingBTN";
            this.StopTalkingBTN.Size = new System.Drawing.Size(115, 53);
            this.StopTalkingBTN.TabIndex = 9;
            this.StopTalkingBTN.Text = "Stop Talking";
            this.StopTalkingBTN.UseVisualStyleBackColor = true;
            this.StopTalkingBTN.Click += new System.EventHandler(this.StopTalkingBTN_Click);
            // 
            // ServerIPTXT
            // 
            this.ServerIPTXT.Location = new System.Drawing.Point(73, 21);
            this.ServerIPTXT.Name = "ServerIPTXT";
            this.ServerIPTXT.Size = new System.Drawing.Size(120, 20);
            this.ServerIPTXT.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Server IP";
            // 
            // StartTalkingBTN
            // 
            this.StartTalkingBTN.Enabled = false;
            this.StartTalkingBTN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTalkingBTN.Location = new System.Drawing.Point(73, 128);
            this.StartTalkingBTN.Name = "StartTalkingBTN";
            this.StartTalkingBTN.Size = new System.Drawing.Size(117, 53);
            this.StartTalkingBTN.TabIndex = 6;
            this.StartTalkingBTN.Text = "Talk";
            this.StartTalkingBTN.UseVisualStyleBackColor = true;
            this.StartTalkingBTN.Click += new System.EventHandler(this.StartTalkingBTN_Click);
            // 
            // JoinBTN
            // 
            this.JoinBTN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoinBTN.Location = new System.Drawing.Point(73, 47);
            this.JoinBTN.Name = "JoinBTN";
            this.JoinBTN.Size = new System.Drawing.Size(119, 59);
            this.JoinBTN.TabIndex = 5;
            this.JoinBTN.Text = "Join Chat";
            this.JoinBTN.UseVisualStyleBackColor = true;
            this.JoinBTN.Click += new System.EventHandler(this.JoinBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(616, 316);
            this.Controls.Add(this.StopTalkingBTN);
            this.Controls.Add(this.ServerIPTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartTalkingBTN);
            this.Controls.Add(this.JoinBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StopTalkingBTN;
        private System.Windows.Forms.TextBox ServerIPTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartTalkingBTN;
        private System.Windows.Forms.Button JoinBTN;
    }
}

