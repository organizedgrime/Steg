using System;

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
            this.folderChooser = new System.Windows.Forms.Button();
            this.fileChooser = new System.Windows.Forms.Button();
            this.maxChars = new System.Windows.Forms.Label();
            this.outputDirectory = new System.Windows.Forms.TextBox();
            this.OutputDirectoryLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.TextBox();
            this.retrieveInput = new System.Windows.Forms.Button();
            this.filename = new System.Windows.Forms.TextBox();
            this.Read = new System.Windows.Forms.TabPage();
            this.filename2 = new System.Windows.Forms.TextBox();
            this.fileChooser2 = new System.Windows.Forms.Button();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.inputLabel = new System.Windows.Forms.Label();
            this.LSBTab.SuspendLayout();
            this.Write.SuspendLayout();
            this.Read.SuspendLayout();
            this.SuspendLayout();
            // 
            // LSBTab
            // 
            this.LSBTab.Controls.Add(this.Write);
            this.LSBTab.Controls.Add(this.Read);
            this.LSBTab.Location = new System.Drawing.Point(13, 13);
            this.LSBTab.Name = "LSBTab";
            this.LSBTab.SelectedIndex = 0;
            this.LSBTab.Size = new System.Drawing.Size(259, 237);
            this.LSBTab.TabIndex = 0;
            // 
            // Write
            // 
            this.Write.Controls.Add(this.inputLabel);
            this.Write.Controls.Add(this.folderChooser);
            this.Write.Controls.Add(this.fileChooser);
            this.Write.Controls.Add(this.maxChars);
            this.Write.Controls.Add(this.outputDirectory);
            this.Write.Controls.Add(this.OutputDirectoryLabel);
            this.Write.Controls.Add(this.MessageLabel);
            this.Write.Controls.Add(this.message);
            this.Write.Controls.Add(this.retrieveInput);
            this.Write.Controls.Add(this.filename);
            this.Write.Location = new System.Drawing.Point(4, 22);
            this.Write.Name = "Write";
            this.Write.Padding = new System.Windows.Forms.Padding(3);
            this.Write.Size = new System.Drawing.Size(251, 211);
            this.Write.TabIndex = 0;
            this.Write.Text = "Write";
            this.Write.UseVisualStyleBackColor = true;
            // 
            // folderChooser
            // 
            this.folderChooser.Location = new System.Drawing.Point(187, 65);
            this.folderChooser.Name = "folderChooser";
            this.folderChooser.Size = new System.Drawing.Size(30, 20);
            this.folderChooser.TabIndex = 19;
            this.folderChooser.Text = "...";
            this.folderChooser.UseVisualStyleBackColor = true;
            this.folderChooser.Click += new System.EventHandler(this.folderChooser_Click);
            // 
            // fileChooser
            // 
            this.fileChooser.Location = new System.Drawing.Point(187, 24);
            this.fileChooser.Name = "fileChooser";
            this.fileChooser.Size = new System.Drawing.Size(30, 20);
            this.fileChooser.TabIndex = 18;
            this.fileChooser.Text = "...";
            this.fileChooser.UseVisualStyleBackColor = true;
            this.fileChooser.Click += new System.EventHandler(this.fileChooser_Click);
            // 
            // maxChars
            // 
            this.maxChars.AutoSize = true;
            this.maxChars.Location = new System.Drawing.Point(117, 98);
            this.maxChars.Name = "maxChars";
            this.maxChars.Size = new System.Drawing.Size(63, 13);
            this.maxChars.TabIndex = 17;
            this.maxChars.Text = "Max Chars: ";
            // 
            // outputDirectory
            // 
            this.outputDirectory.Location = new System.Drawing.Point(6, 66);
            this.outputDirectory.Name = "outputDirectory";
            this.outputDirectory.Size = new System.Drawing.Size(175, 20);
            this.outputDirectory.TabIndex = 16;
            this.outputDirectory.Text = "C:\\Users\\Nico\\Desktop";
            // 
            // OutputDirectoryLabel
            // 
            this.OutputDirectoryLabel.AutoSize = true;
            this.OutputDirectoryLabel.Location = new System.Drawing.Point(10, 50);
            this.OutputDirectoryLabel.Name = "OutputDirectoryLabel";
            this.OutputDirectoryLabel.Size = new System.Drawing.Size(87, 13);
            this.OutputDirectoryLabel.TabIndex = 15;
            this.OutputDirectoryLabel.Text = "Output Directory:";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(7, 98);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(104, 13);
            this.MessageLabel.TabIndex = 14;
            this.MessageLabel.Text = "Message to encode:";
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(6, 114);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(175, 61);
            this.message.TabIndex = 12;
            // 
            // retrieveInput
            // 
            this.retrieveInput.AccessibleName = "";
            this.retrieveInput.Location = new System.Drawing.Point(54, 187);
            this.retrieveInput.Name = "retrieveInput";
            this.retrieveInput.Size = new System.Drawing.Size(75, 23);
            this.retrieveInput.TabIndex = 11;
            this.retrieveInput.Text = "Write";
            this.retrieveInput.UseVisualStyleBackColor = true;
            this.retrieveInput.Click += new System.EventHandler(this.retrieveInput_Click);
            // 
            // filename
            // 
            this.filename.AccessibleName = "";
            this.filename.Location = new System.Drawing.Point(6, 24);
            this.filename.Name = "filename";
            this.filename.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.filename.Size = new System.Drawing.Size(175, 20);
            this.filename.TabIndex = 10;
            this.filename.Text = "C:\\Users\\Nico\\Desktop";
            // 
            // Read
            // 
            this.Read.Controls.Add(this.filename2);
            this.Read.Controls.Add(this.fileChooser2);
            this.Read.Controls.Add(this.selectFileButton);
            this.Read.Location = new System.Drawing.Point(4, 22);
            this.Read.Name = "Read";
            this.Read.Padding = new System.Windows.Forms.Padding(3);
            this.Read.Size = new System.Drawing.Size(251, 211);
            this.Read.TabIndex = 1;
            this.Read.Text = "Read";
            this.Read.UseVisualStyleBackColor = true;
            // 
            // filename2
            // 
            this.filename2.Location = new System.Drawing.Point(6, 19);
            this.filename2.Name = "filename2";
            this.filename2.Size = new System.Drawing.Size(130, 20);
            this.filename2.TabIndex = 11;
            this.filename2.Text = "C:\\Users\\Nico\\Desktop\\output.png";
            // 
            // fileChooser2
            // 
            this.fileChooser2.Location = new System.Drawing.Point(142, 19);
            this.fileChooser2.Name = "fileChooser2";
            this.fileChooser2.Size = new System.Drawing.Size(30, 20);
            this.fileChooser2.TabIndex = 13;
            this.fileChooser2.Text = "...";
            this.fileChooser2.UseVisualStyleBackColor = true;
            this.fileChooser2.Click += new System.EventHandler(this.fileChooser2_Click);
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(178, 19);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(70, 20);
            this.selectFileButton.TabIndex = 12;
            this.selectFileButton.Text = "Select";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(13, 5);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(66, 13);
            this.inputLabel.TabIndex = 20;
            this.inputLabel.Text = "Input Image:";
            // 
            // LSBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.LSBTab);
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

        private System.Windows.Forms.TabControl LSBTab;
        private System.Windows.Forms.TabPage Write;
        private System.Windows.Forms.TabPage Read;
        private System.Windows.Forms.Button folderChooser;
        private System.Windows.Forms.Button fileChooser;
        private System.Windows.Forms.Label maxChars;
        private System.Windows.Forms.TextBox outputDirectory;
        private System.Windows.Forms.Label OutputDirectoryLabel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Button retrieveInput;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.Button fileChooser2;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.TextBox filename2;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label inputLabel;
    }
}