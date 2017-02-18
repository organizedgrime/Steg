namespace Steg
{
    partial class DisplayOutput
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
            this.OutputTab = new System.Windows.Forms.TabControl();
            this.File = new System.Windows.Forms.TabPage();
            this.txtFileOutput = new System.Windows.Forms.TextBox();
            this.btnFileOutput = new System.Windows.Forms.Button();
            this.lblFileInfoData = new System.Windows.Forms.Label();
            this.lblFileInfo = new System.Windows.Forms.Label();
            this.PlainText = new System.Windows.Forms.TabPage();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.OutputTab.SuspendLayout();
            this.File.SuspendLayout();
            this.PlainText.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputTab
            // 
            this.OutputTab.Controls.Add(this.File);
            this.OutputTab.Controls.Add(this.PlainText);
            this.OutputTab.Location = new System.Drawing.Point(13, 13);
            this.OutputTab.Name = "OutputTab";
            this.OutputTab.SelectedIndex = 0;
            this.OutputTab.Size = new System.Drawing.Size(401, 313);
            this.OutputTab.TabIndex = 0;
            // 
            // File
            // 
            this.File.Controls.Add(this.txtFileOutput);
            this.File.Controls.Add(this.btnFileOutput);
            this.File.Controls.Add(this.lblFileInfoData);
            this.File.Controls.Add(this.lblFileInfo);
            this.File.Location = new System.Drawing.Point(4, 29);
            this.File.Name = "File";
            this.File.Padding = new System.Windows.Forms.Padding(3);
            this.File.Size = new System.Drawing.Size(393, 280);
            this.File.TabIndex = 0;
            this.File.Text = "File";
            this.File.UseVisualStyleBackColor = true;
            // 
            // txtFileOutput
            // 
            this.txtFileOutput.Location = new System.Drawing.Point(15, 98);
            this.txtFileOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFileOutput.Name = "txtFileOutput";
            this.txtFileOutput.Size = new System.Drawing.Size(260, 26);
            this.txtFileOutput.TabIndex = 14;
            // 
            // btnFileOutput
            // 
            this.btnFileOutput.Location = new System.Drawing.Point(283, 98);
            this.btnFileOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFileOutput.Name = "btnFileOutput";
            this.btnFileOutput.Size = new System.Drawing.Size(45, 26);
            this.btnFileOutput.TabIndex = 15;
            this.btnFileOutput.Text = "...";
            this.btnFileOutput.UseVisualStyleBackColor = true;
            this.btnFileOutput.Click += new System.EventHandler(this.btnFileOutput_Click);
            // 
            // lblFileInfoData
            // 
            this.lblFileInfoData.AutoSize = true;
            this.lblFileInfoData.Location = new System.Drawing.Point(11, 31);
            this.lblFileInfoData.Name = "lblFileInfoData";
            this.lblFileInfoData.Size = new System.Drawing.Size(73, 20);
            this.lblFileInfoData.TabIndex = 1;
            this.lblFileInfoData.Text = "unknown";
            // 
            // lblFileInfo
            // 
            this.lblFileInfo.AutoSize = true;
            this.lblFileInfo.Location = new System.Drawing.Point(7, 7);
            this.lblFileInfo.Name = "lblFileInfo";
            this.lblFileInfo.Size = new System.Drawing.Size(70, 20);
            this.lblFileInfo.TabIndex = 0;
            this.lblFileInfo.Text = "File Info:";
            // 
            // PlainText
            // 
            this.PlainText.Controls.Add(this.txtOutput);
            this.PlainText.Location = new System.Drawing.Point(4, 29);
            this.PlainText.Name = "PlainText";
            this.PlainText.Padding = new System.Windows.Forms.Padding(3);
            this.PlainText.Size = new System.Drawing.Size(393, 280);
            this.PlainText.TabIndex = 1;
            this.PlainText.Text = "PlainText";
            this.PlainText.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(7, 7);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(380, 225);
            this.txtOutput.TabIndex = 0;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(165, 352);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(112, 38);
            this.btnSaveFile.TabIndex = 1;
            this.btnSaveFile.Text = "button1";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // DisplayOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.OutputTab);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DisplayOutput";
            this.Text = "DisplayOutput";
            this.OutputTab.ResumeLayout(false);
            this.File.ResumeLayout(false);
            this.File.PerformLayout();
            this.PlainText.ResumeLayout(false);
            this.PlainText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl OutputTab;
        private System.Windows.Forms.TabPage File;
        private System.Windows.Forms.TabPage PlainText;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblFileInfo;
        private System.Windows.Forms.Label lblFileInfoData;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.TextBox txtFileOutput;
        private System.Windows.Forms.Button btnFileOutput;
    }
}