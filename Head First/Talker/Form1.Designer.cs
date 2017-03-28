namespace Talker
{
    partial class frmTalkToMe
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
            this.txtBlah = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnSpeakToMe = new System.Windows.Forms.Button();
            this.lblSayThis = new System.Windows.Forms.Label();
            this.lblNumTimes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBlah
            // 
            this.txtBlah.Location = new System.Drawing.Point(89, 12);
            this.txtBlah.Name = "txtBlah";
            this.txtBlah.Size = new System.Drawing.Size(183, 20);
            this.txtBlah.TabIndex = 0;
            this.txtBlah.Text = "Hello!";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(89, 62);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // btnSpeakToMe
            // 
            this.btnSpeakToMe.Location = new System.Drawing.Point(89, 102);
            this.btnSpeakToMe.Name = "btnSpeakToMe";
            this.btnSpeakToMe.Size = new System.Drawing.Size(120, 23);
            this.btnSpeakToMe.TabIndex = 2;
            this.btnSpeakToMe.Text = "Speak to me!";
            this.btnSpeakToMe.UseVisualStyleBackColor = true;
            this.btnSpeakToMe.Click += new System.EventHandler(this.btnSpeakToMe_Click);
            // 
            // lblSayThis
            // 
            this.lblSayThis.AutoSize = true;
            this.lblSayThis.Location = new System.Drawing.Point(12, 15);
            this.lblSayThis.Name = "lblSayThis";
            this.lblSayThis.Size = new System.Drawing.Size(47, 13);
            this.lblSayThis.TabIndex = 3;
            this.lblSayThis.Text = "Say this:";
            // 
            // lblNumTimes
            // 
            this.lblNumTimes.AutoSize = true;
            this.lblNumTimes.Location = new System.Drawing.Point(12, 64);
            this.lblNumTimes.Name = "lblNumTimes";
            this.lblNumTimes.Size = new System.Drawing.Size(56, 13);
            this.lblNumTimes.TabIndex = 4;
            this.lblNumTimes.Tag = "";
            this.lblNumTimes.Text = "# of times:";
            // 
            // frmTalkToMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(284, 131);
            this.Controls.Add(this.lblNumTimes);
            this.Controls.Add(this.lblSayThis);
            this.Controls.Add(this.btnSpeakToMe);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtBlah);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTalkToMe";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Talker Tester";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBlah;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnSpeakToMe;
        private System.Windows.Forms.Label lblSayThis;
        private System.Windows.Forms.Label lblNumTimes;
    }
}

