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
            this.btnOutputDir = new System.Windows.Forms.Button();
            this.btnInputFile = new System.Windows.Forms.Button();
            this.lblSecretBytes = new System.Windows.Forms.Label();
            this.txtOutputDir = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblSecretMessage = new System.Windows.Forms.Label();
            this.txtSecretMessage = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.Read = new System.Windows.Forms.TabPage();
            this.lblSecretInput = new System.Windows.Forms.Label();
            this.filename2 = new System.Windows.Forms.TextBox();
            this.fileChooser2 = new System.Windows.Forms.Button();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileOutput = new System.Windows.Forms.TextBox();
            this.btnFileOutput = new System.Windows.Forms.Button();
            this.cbxTrimMarker = new System.Windows.Forms.CheckBox();
            this.cbxPlaintext = new System.Windows.Forms.CheckBox();
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
            this.Write.Controls.Add(this.btnOutputDir);
            this.Write.Controls.Add(this.btnInputFile);
            this.Write.Controls.Add(this.lblSecretBytes);
            this.Write.Controls.Add(this.txtOutputDir);
            this.Write.Controls.Add(this.lblOutput);
            this.Write.Controls.Add(this.lblSecretMessage);
            this.Write.Controls.Add(this.txtSecretMessage);
            this.Write.Controls.Add(this.btnWrite);
            this.Write.Controls.Add(this.txtInputFile);
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
            this.endMarkBool.Location = new System.Drawing.Point(119, 122);
            this.endMarkBool.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.endMarkBool.Name = "endMarkBool";
            this.endMarkBool.Size = new System.Drawing.Size(146, 24);
            this.endMarkBool.TabIndex = 25;
            this.endMarkBool.Text = "Use Endmarker";
            this.endMarkBool.UseVisualStyleBackColor = true;
            // 
            // btnSecretFile
            // 
            this.btnSecretFile.Location = new System.Drawing.Point(277, 176);
            this.btnSecretFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSecretFile.Name = "btnSecretFile";
            this.btnSecretFile.Size = new System.Drawing.Size(45, 26);
            this.btnSecretFile.TabIndex = 24;
            this.btnSecretFile.Text = "...";
            this.btnSecretFile.UseVisualStyleBackColor = true;
            this.btnSecretFile.Visible = false;
            this.btnSecretFile.Click += new System.EventHandler(this.fileInputButton_Click);
            // 
            // txtSecretFile
            // 
            this.txtSecretFile.Location = new System.Drawing.Point(9, 176);
            this.txtSecretFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSecretFile.Name = "txtSecretFile";
            this.txtSecretFile.Size = new System.Drawing.Size(260, 26);
            this.txtSecretFile.TabIndex = 23;
            this.txtSecretFile.Visible = false;
            // 
            // lblSecretFile
            // 
            this.lblSecretFile.AutoSize = true;
            this.lblSecretFile.Location = new System.Drawing.Point(8, 151);
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
            this.fileInputBool.Location = new System.Drawing.Point(8, 122);
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
            // btnOutputDir
            // 
            this.btnOutputDir.Location = new System.Drawing.Point(278, 86);
            this.btnOutputDir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOutputDir.Name = "btnOutputDir";
            this.btnOutputDir.Size = new System.Drawing.Size(45, 26);
            this.btnOutputDir.TabIndex = 19;
            this.btnOutputDir.Text = "...";
            this.btnOutputDir.UseVisualStyleBackColor = true;
            this.btnOutputDir.Click += new System.EventHandler(this.folderChooser_Click);
            // 
            // btnInputFile
            // 
            this.btnInputFile.Location = new System.Drawing.Point(278, 30);
            this.btnInputFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInputFile.Name = "btnInputFile";
            this.btnInputFile.Size = new System.Drawing.Size(45, 26);
            this.btnInputFile.TabIndex = 18;
            this.btnInputFile.Text = "...";
            this.btnInputFile.UseVisualStyleBackColor = true;
            this.btnInputFile.Click += new System.EventHandler(this.fileChooser_Click);
            // 
            // lblSecretBytes
            // 
            this.lblSecretBytes.AutoSize = true;
            this.lblSecretBytes.Location = new System.Drawing.Point(174, 151);
            this.lblSecretBytes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecretBytes.Name = "lblSecretBytes";
            this.lblSecretBytes.Size = new System.Drawing.Size(90, 20);
            this.lblSecretBytes.TabIndex = 17;
            this.lblSecretBytes.Text = "Max Bytes: ";
            // 
            // txtOutputDir
            // 
            this.txtOutputDir.Location = new System.Drawing.Point(10, 86);
            this.txtOutputDir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOutputDir.Name = "txtOutputDir";
            this.txtOutputDir.Size = new System.Drawing.Size(260, 26);
            this.txtOutputDir.TabIndex = 16;
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
            this.lblSecretMessage.Location = new System.Drawing.Point(8, 151);
            this.lblSecretMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecretMessage.Name = "lblSecretMessage";
            this.lblSecretMessage.Size = new System.Drawing.Size(153, 20);
            this.lblSecretMessage.TabIndex = 14;
            this.lblSecretMessage.Text = "Message to encode:";
            // 
            // txtSecretMessage
            // 
            this.txtSecretMessage.Location = new System.Drawing.Point(9, 176);
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
            // txtInputFile
            // 
            this.txtInputFile.AccessibleName = "";
            this.txtInputFile.Location = new System.Drawing.Point(10, 30);
            this.txtInputFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtInputFile.Size = new System.Drawing.Size(260, 26);
            this.txtInputFile.TabIndex = 10;
            // 
            // Read
            // 
            this.Read.Controls.Add(this.cbxPlaintext);
            this.Read.Controls.Add(this.cbxTrimMarker);
            this.Read.Controls.Add(this.label1);
            this.Read.Controls.Add(this.txtFileOutput);
            this.Read.Controls.Add(this.btnFileOutput);
            this.Read.Controls.Add(this.lblSecretInput);
            this.Read.Controls.Add(this.filename2);
            this.Read.Controls.Add(this.fileChooser2);
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
            this.lblSecretInput.Location = new System.Drawing.Point(7, 5);
            this.lblSecretInput.Name = "lblSecretInput";
            this.lblSecretInput.Size = new System.Drawing.Size(79, 20);
            this.lblSecretInput.TabIndex = 31;
            this.lblSecretInput.Text = "Input File:";
            // 
            // filename2
            // 
            this.filename2.Location = new System.Drawing.Point(11, 30);
            this.filename2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filename2.Name = "filename2";
            this.filename2.Size = new System.Drawing.Size(260, 26);
            this.filename2.TabIndex = 11;
            // 
            // fileChooser2
            // 
            this.fileChooser2.Location = new System.Drawing.Point(279, 30);
            this.fileChooser2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fileChooser2.Name = "fileChooser2";
            this.fileChooser2.Size = new System.Drawing.Size(45, 26);
            this.fileChooser2.TabIndex = 13;
            this.fileChooser2.Text = "...";
            this.fileChooser2.UseVisualStyleBackColor = true;
            this.fileChooser2.Click += new System.EventHandler(this.fileChooser2_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Output Directory:";
            // 
            // txtFileOutput
            // 
            this.txtFileOutput.Location = new System.Drawing.Point(11, 86);
            this.txtFileOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFileOutput.Name = "txtFileOutput";
            this.txtFileOutput.Size = new System.Drawing.Size(260, 26);
            this.txtFileOutput.TabIndex = 32;
            // 
            // btnFileOutput
            // 
            this.btnFileOutput.Location = new System.Drawing.Point(279, 86);
            this.btnFileOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFileOutput.Name = "btnFileOutput";
            this.btnFileOutput.Size = new System.Drawing.Size(45, 26);
            this.btnFileOutput.TabIndex = 33;
            this.btnFileOutput.Text = "...";
            this.btnFileOutput.UseVisualStyleBackColor = true;
            this.btnFileOutput.Click += new System.EventHandler(this.btnFileOutput_Click);
            // 
            // cbxTrimMarker
            // 
            this.cbxTrimMarker.AutoSize = true;
            this.cbxTrimMarker.Location = new System.Drawing.Point(8, 121);
            this.cbxTrimMarker.Name = "cbxTrimMarker";
            this.cbxTrimMarker.Size = new System.Drawing.Size(147, 24);
            this.cbxTrimMarker.TabIndex = 35;
            this.cbxTrimMarker.Text = "Trim Endmarker";
            this.cbxTrimMarker.UseVisualStyleBackColor = true;
            // 
            // cbxPlaintext
            // 
            this.cbxPlaintext.AutoSize = true;
            this.cbxPlaintext.Location = new System.Drawing.Point(7, 151);
            this.cbxPlaintext.Name = "cbxPlaintext";
            this.cbxPlaintext.Size = new System.Drawing.Size(95, 24);
            this.cbxPlaintext.TabIndex = 36;
            this.cbxPlaintext.Text = "Plaintext";
            this.cbxPlaintext.UseVisualStyleBackColor = true;
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
        private Button btnOutputDir;
        private Button btnInputFile;
        private Label lblSecretBytes;
        private TextBox txtOutputDir;
        private Label lblOutput;
        private Label lblSecretMessage;
        private TextBox txtSecretMessage;
        private Button btnWrite;
        private TextBox txtInputFile;
        private Button fileChooser2;
        private Button selectFileButton;
        private TextBox filename2;
        private DirectoryEntry directoryEntry1;
        private Label lblInput;
        private CheckBox fileInputBool;
        private Button btnSecretFile;
        private TextBox txtSecretFile;
        private Label lblSecretFile;
        private CheckBox endMarkBool;
        private Label lblSecretInput;
        private Label label1;
        private TextBox txtFileOutput;
        private Button btnFileOutput;
        private CheckBox cbxTrimMarker;
        private CheckBox cbxPlaintext;
    }
}