using System.DirectoryServices;
using System.Windows.Forms;

namespace Steg
{
    partial class LSBForm
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
            this.LSBTab = new System.Windows.Forms.TabControl();
            this.Write = new System.Windows.Forms.TabPage();
            this.endMarkBool = new System.Windows.Forms.CheckBox();
            this.btnSecretFile = new System.Windows.Forms.Button();
            this.txtSecretFile = new System.Windows.Forms.TextBox();
            this.lblSecretFile = new System.Windows.Forms.Label();
            this.fileInputBool = new System.Windows.Forms.CheckBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.btnWriteDir = new System.Windows.Forms.Button();
            this.btnWriteImage = new System.Windows.Forms.Button();
            this.lblSecretBytes = new System.Windows.Forms.Label();
            this.txtWriteDir = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblSecretMessage = new System.Windows.Forms.Label();
            this.txtSecretMessage = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.txtWriteImage = new System.Windows.Forms.TextBox();
            this.Read = new System.Windows.Forms.TabPage();
            this.lblSecretInput = new System.Windows.Forms.Label();
            this.txtReadImage = new System.Windows.Forms.TextBox();
            this.btnReadImage = new System.Windows.Forms.Button();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.lblSecretOutput = new System.Windows.Forms.Label();
            this.txtReadDir = new System.Windows.Forms.TextBox();
            this.btnReadDir = new System.Windows.Forms.Button();
            this.cbxTrimMarker = new System.Windows.Forms.CheckBox();
            this.LSBTab.SuspendLayout();
            this.Write.SuspendLayout();
            this.Read.SuspendLayout();
            this.SuspendLayout();
            // 
            // LSBTab
            // 
            this.LSBTab.Controls.Add(this.Write);
            this.LSBTab.Controls.Add(this.Read);
            this.LSBTab.Location = new System.Drawing.Point(20, 20);
            this.LSBTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LSBTab.Name = "LSBTab";
            this.LSBTab.SelectedIndex = 0;
            this.LSBTab.Size = new System.Drawing.Size(352, 356);
            this.LSBTab.TabIndex = 0;
            // 
            // Write
            // 
            this.Write.Controls.Add(this.endMarkBool);
            this.Write.Controls.Add(this.btnSecretFile);
            this.Write.Controls.Add(this.txtSecretFile);
            this.Write.Controls.Add(this.lblSecretFile);
            this.Write.Controls.Add(this.fileInputBool);
            this.Write.Controls.Add(this.lblInput);
            this.Write.Controls.Add(this.btnWriteDir);
            this.Write.Controls.Add(this.btnWriteImage);
            this.Write.Controls.Add(this.lblSecretBytes);
            this.Write.Controls.Add(this.txtWriteDir);
            this.Write.Controls.Add(this.lblOutput);
            this.Write.Controls.Add(this.lblSecretMessage);
            this.Write.Controls.Add(this.txtSecretMessage);
            this.Write.Controls.Add(this.btnWrite);
            this.Write.Controls.Add(this.txtWriteImage);
            this.Write.Location = new System.Drawing.Point(4, 29);
            this.Write.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Write.Name = "Write";
            this.Write.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Write.Size = new System.Drawing.Size(344, 323);
            this.Write.TabIndex = 0;
            this.Write.Text = "Write";
            this.Write.UseVisualStyleBackColor = true;
            // 
            // endMarkBool
            // 
            this.endMarkBool.AutoSize = true;
            this.endMarkBool.Checked = true;
            this.endMarkBool.CheckState = System.Windows.Forms.CheckState.Checked;
            this.endMarkBool.Location = new System.Drawing.Point(121, 120);
            this.endMarkBool.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.endMarkBool.Name = "endMarkBool";
            this.endMarkBool.Size = new System.Drawing.Size(146, 24);
            this.endMarkBool.TabIndex = 25;
            this.endMarkBool.Text = "Use Endmarker";
            this.endMarkBool.UseVisualStyleBackColor = true;
            // 
            // btnSecretFile
            // 
            this.btnSecretFile.Location = new System.Drawing.Point(278, 181);
            this.btnSecretFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSecretFile.Name = "btnSecretFile";
            this.btnSecretFile.Size = new System.Drawing.Size(45, 38);
            this.btnSecretFile.TabIndex = 24;
            this.btnSecretFile.Text = "...";
            this.btnSecretFile.UseVisualStyleBackColor = true;
            this.btnSecretFile.Visible = false;
            this.btnSecretFile.Click += new System.EventHandler(this.fileInputButton_Click);
            // 
            // txtSecretFile
            // 
            this.txtSecretFile.Location = new System.Drawing.Point(10, 187);
            this.txtSecretFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSecretFile.Name = "txtSecretFile";
            this.txtSecretFile.Size = new System.Drawing.Size(260, 26);
            this.txtSecretFile.TabIndex = 23;
            this.txtSecretFile.Visible = false;
            // 
            // lblSecretFile
            // 
            this.lblSecretFile.AutoSize = true;
            this.lblSecretFile.Location = new System.Drawing.Point(8, 162);
            this.lblSecretFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecretFile.Name = "lblSecretFile";
            this.lblSecretFile.Size = new System.Drawing.Size(115, 20);
            this.lblSecretFile.TabIndex = 22;
            this.lblSecretFile.Text = "File to Encode:";
            this.lblSecretFile.Visible = false;
            // 
            // fileInputBool
            // 
            this.fileInputBool.AutoSize = true;
            this.fileInputBool.Location = new System.Drawing.Point(12, 120);
            this.fileInputBool.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fileInputBool.Name = "fileInputBool";
            this.fileInputBool.Size = new System.Drawing.Size(101, 24);
            this.fileInputBool.TabIndex = 21;
            this.fileInputBool.Text = "From File";
            this.fileInputBool.UseVisualStyleBackColor = true;
            this.fileInputBool.CheckedChanged += new System.EventHandler(this.fileInputBool_CheckedChanged);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(8, 5);
            this.lblInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(99, 20);
            this.lblInput.TabIndex = 20;
            this.lblInput.Text = "Input Image:";
            // 
            // btnWriteDir
            // 
            this.btnWriteDir.Location = new System.Drawing.Point(278, 80);
            this.btnWriteDir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWriteDir.Name = "btnWriteDir";
            this.btnWriteDir.Size = new System.Drawing.Size(45, 38);
            this.btnWriteDir.TabIndex = 19;
            this.btnWriteDir.Text = "...";
            this.btnWriteDir.UseVisualStyleBackColor = true;
            this.btnWriteDir.Click += new System.EventHandler(this.folderChooser_Click);
            // 
            // btnWriteImage
            // 
            this.btnWriteImage.Location = new System.Drawing.Point(278, 24);
            this.btnWriteImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWriteImage.Name = "btnWriteImage";
            this.btnWriteImage.Size = new System.Drawing.Size(45, 38);
            this.btnWriteImage.TabIndex = 18;
            this.btnWriteImage.Text = "...";
            this.btnWriteImage.UseVisualStyleBackColor = true;
            this.btnWriteImage.Click += new System.EventHandler(this.fileChooser_Click);
            // 
            // lblSecretBytes
            // 
            this.lblSecretBytes.AutoSize = true;
            this.lblSecretBytes.Location = new System.Drawing.Point(174, 162);
            this.lblSecretBytes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecretBytes.Name = "lblSecretBytes";
            this.lblSecretBytes.Size = new System.Drawing.Size(90, 20);
            this.lblSecretBytes.TabIndex = 17;
            this.lblSecretBytes.Text = "Max Bytes: ";
            // 
            // txtWriteDir
            // 
            this.txtWriteDir.Location = new System.Drawing.Point(10, 86);
            this.txtWriteDir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWriteDir.Name = "txtWriteDir";
            this.txtWriteDir.Size = new System.Drawing.Size(260, 26);
            this.txtWriteDir.TabIndex = 16;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(8, 61);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(129, 20);
            this.lblOutput.TabIndex = 15;
            this.lblOutput.Text = "Output Directory:";
            // 
            // lblSecretMessage
            // 
            this.lblSecretMessage.AutoSize = true;
            this.lblSecretMessage.Location = new System.Drawing.Point(8, 162);
            this.lblSecretMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecretMessage.Name = "lblSecretMessage";
            this.lblSecretMessage.Size = new System.Drawing.Size(153, 20);
            this.lblSecretMessage.TabIndex = 14;
            this.lblSecretMessage.Text = "Message to encode:";
            // 
            // txtSecretMessage
            // 
            this.txtSecretMessage.Location = new System.Drawing.Point(12, 187);
            this.txtSecretMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSecretMessage.Multiline = true;
            this.txtSecretMessage.Name = "txtSecretMessage";
            this.txtSecretMessage.Size = new System.Drawing.Size(314, 78);
            this.txtSecretMessage.TabIndex = 12;
            // 
            // btnWrite
            // 
            this.btnWrite.AccessibleName = "";
            this.btnWrite.Location = new System.Drawing.Point(115, 275);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(112, 38);
            this.btnWrite.TabIndex = 11;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.retrieveInput_Click);
            // 
            // txtWriteImage
            // 
            this.txtWriteImage.AccessibleName = "";
            this.txtWriteImage.Location = new System.Drawing.Point(10, 30);
            this.txtWriteImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWriteImage.Name = "txtWriteImage";
            this.txtWriteImage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWriteImage.Size = new System.Drawing.Size(260, 26);
            this.txtWriteImage.TabIndex = 10;
            // 
            // Read
            // 
            this.Read.Controls.Add(this.cbxTrimMarker);
            this.Read.Controls.Add(this.lblSecretOutput);
            this.Read.Controls.Add(this.txtReadDir);
            this.Read.Controls.Add(this.btnReadDir);
            this.Read.Controls.Add(this.lblSecretInput);
            this.Read.Controls.Add(this.txtReadImage);
            this.Read.Controls.Add(this.btnReadImage);
            this.Read.Controls.Add(this.selectFileButton);
            this.Read.Location = new System.Drawing.Point(4, 29);
            this.Read.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Read.Name = "Read";
            this.Read.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Read.Size = new System.Drawing.Size(344, 323);
            this.Read.TabIndex = 1;
            this.Read.Text = "Read";
            this.Read.UseVisualStyleBackColor = true;
            // 
            // lblSecretInput
            // 
            this.lblSecretInput.AutoSize = true;
            this.lblSecretInput.Location = new System.Drawing.Point(8, 5);
            this.lblSecretInput.Name = "lblSecretInput";
            this.lblSecretInput.Size = new System.Drawing.Size(79, 20);
            this.lblSecretInput.TabIndex = 31;
            this.lblSecretInput.Text = "Input File:";
            // 
            // txtReadImage
            // 
            this.txtReadImage.Location = new System.Drawing.Point(10, 30);
            this.txtReadImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReadImage.Name = "txtReadImage";
            this.txtReadImage.Size = new System.Drawing.Size(260, 26);
            this.txtReadImage.TabIndex = 11;
            // 
            // btnReadImage
            // 
            this.btnReadImage.Location = new System.Drawing.Point(278, 24);
            this.btnReadImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReadImage.Name = "btnReadImage";
            this.btnReadImage.Size = new System.Drawing.Size(45, 38);
            this.btnReadImage.TabIndex = 13;
            this.btnReadImage.Text = "...";
            this.btnReadImage.UseVisualStyleBackColor = true;
            this.btnReadImage.Click += new System.EventHandler(this.fileChooser2_Click);
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(115, 275);
            this.selectFileButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(112, 38);
            this.selectFileButton.TabIndex = 12;
            this.selectFileButton.Text = "Read";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // lblSecretOutput
            // 
            this.lblSecretOutput.AutoSize = true;
            this.lblSecretOutput.Location = new System.Drawing.Point(8, 61);
            this.lblSecretOutput.Name = "lblSecretOutput";
            this.lblSecretOutput.Size = new System.Drawing.Size(129, 20);
            this.lblSecretOutput.TabIndex = 34;
            this.lblSecretOutput.Text = "Output Directory:";
            // 
            // txtReadDir
            // 
            this.txtReadDir.Location = new System.Drawing.Point(10, 86);
            this.txtReadDir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReadDir.Name = "txtReadDir";
            this.txtReadDir.Size = new System.Drawing.Size(260, 26);
            this.txtReadDir.TabIndex = 32;
            // 
            // btnReadDir
            // 
            this.btnReadDir.Location = new System.Drawing.Point(278, 80);
            this.btnReadDir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReadDir.Name = "btnReadDir";
            this.btnReadDir.Size = new System.Drawing.Size(45, 38);
            this.btnReadDir.TabIndex = 33;
            this.btnReadDir.Text = "...";
            this.btnReadDir.UseVisualStyleBackColor = true;
            this.btnReadDir.Click += new System.EventHandler(this.btnFileOutput_Click);
            // 
            // cbxTrimMarker
            // 
            this.cbxTrimMarker.AutoSize = true;
            this.cbxTrimMarker.Location = new System.Drawing.Point(12, 120);
            this.cbxTrimMarker.Name = "cbxTrimMarker";
            this.cbxTrimMarker.Size = new System.Drawing.Size(147, 24);
            this.cbxTrimMarker.TabIndex = 35;
            this.cbxTrimMarker.Text = "Trim Endmarker";
            this.cbxTrimMarker.UseVisualStyleBackColor = true;
            // 
            // LSBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 390);
            this.Controls.Add(this.LSBTab);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LSBForm";
            this.Text = "LSBForm";
            this.LSBTab.ResumeLayout(false);
            this.Write.ResumeLayout(false);
            this.Write.PerformLayout();
            this.Read.ResumeLayout(false);
            this.Read.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl LSBTab;
        private TabPage Write;
        private TabPage Read;
        private Button btnWriteDir;
        private Button btnWriteImage;
        private Label lblSecretBytes;
        private TextBox txtWriteDir;
        private Label lblOutput;
        private Label lblSecretMessage;
        private TextBox txtSecretMessage;
        private Button btnWrite;
        private TextBox txtWriteImage;
        private Button btnReadImage;
        private Button selectFileButton;
        private TextBox txtReadImage;
        private DirectoryEntry directoryEntry1;
        private Label lblInput;
        private CheckBox fileInputBool;
        private Button btnSecretFile;
        private TextBox txtSecretFile;
        private Label lblSecretFile;
        private CheckBox endMarkBool;
        private Label lblSecretInput;
        private Label lblSecretOutput;
        private TextBox txtReadDir;
        private Button btnReadDir;
        private CheckBox cbxTrimMarker;
    }
}