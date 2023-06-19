namespace SendKeyToWindow
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
            this.lbHandler = new System.Windows.Forms.Label();
            this.lbActiveWindow = new System.Windows.Forms.Label();
            this.btnTraceActiveWindow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbSerch = new System.Windows.Forms.Label();
            this.rtxtCommandBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbHandler
            // 
            this.lbHandler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbHandler.AutoSize = true;
            this.lbHandler.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHandler.Location = new System.Drawing.Point(26, 49);
            this.lbHandler.Name = "lbHandler";
            this.lbHandler.Size = new System.Drawing.Size(77, 21);
            this.lbHandler.TabIndex = 0;
            this.lbHandler.Text = "Handler :";
            // 
            // lbActiveWindow
            // 
            this.lbActiveWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbActiveWindow.AutoSize = true;
            this.lbActiveWindow.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActiveWindow.Location = new System.Drawing.Point(26, 82);
            this.lbActiveWindow.Name = "lbActiveWindow";
            this.lbActiveWindow.Size = new System.Drawing.Size(135, 21);
            this.lbActiveWindow.TabIndex = 0;
            this.lbActiveWindow.Text = "Active Window :";
            // 
            // btnTraceActiveWindow
            // 
            this.btnTraceActiveWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTraceActiveWindow.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTraceActiveWindow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraceActiveWindow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTraceActiveWindow.Location = new System.Drawing.Point(30, 116);
            this.btnTraceActiveWindow.Name = "btnTraceActiveWindow";
            this.btnTraceActiveWindow.Size = new System.Drawing.Size(243, 43);
            this.btnTraceActiveWindow.TabIndex = 1;
            this.btnTraceActiveWindow.Text = "Trace Active Window";
            this.btnTraceActiveWindow.UseVisualStyleBackColor = false;
            this.btnTraceActiveWindow.Click += new System.EventHandler(this.btnTraceActiveWindow_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "N.T : This Application serch active window after 3s";
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.Green;
            this.lbStatus.Location = new System.Drawing.Point(28, 162);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(41, 15);
            this.lbStatus.TabIndex = 3;
            this.lbStatus.Text = "Status";
            // 
            // lbSerch
            // 
            this.lbSerch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSerch.AutoSize = true;
            this.lbSerch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSerch.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbSerch.Location = new System.Drawing.Point(279, 128);
            this.lbSerch.Name = "lbSerch";
            this.lbSerch.Size = new System.Drawing.Size(67, 19);
            this.lbSerch.TabIndex = 3;
            this.lbSerch.Text = "Serching";
            // 
            // rtxtCommandBox
            // 
            this.rtxtCommandBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxtCommandBox.Location = new System.Drawing.Point(30, 222);
            this.rtxtCommandBox.Name = "rtxtCommandBox";
            this.rtxtCommandBox.Size = new System.Drawing.Size(619, 202);
            this.rtxtCommandBox.TabIndex = 4;
            this.rtxtCommandBox.Text = "";
            this.rtxtCommandBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxtCommandBox_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Command Box : ex - ctrl+p for print, typing etc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(677, 498);
            this.Controls.Add(this.rtxtCommandBox);
            this.Controls.Add(this.lbSerch);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTraceActiveWindow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbActiveWindow);
            this.Controls.Add(this.lbHandler);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key Send to Active Window";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHandler;
        private System.Windows.Forms.Label lbActiveWindow;
        private System.Windows.Forms.Button btnTraceActiveWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbSerch;
        private System.Windows.Forms.RichTextBox rtxtCommandBox;
        private System.Windows.Forms.Label label2;
    }
}

