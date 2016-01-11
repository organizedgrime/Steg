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
            this.bitCountLabel = new System.Windows.Forms.Label();
            this.bitCount = new System.Windows.Forms.NumericUpDown();
            this.endMarkBool = new System.Windows.Forms.CheckBox();
            this.fileInputButton = new System.Windows.Forms.Button();
            this.fileInputFilename = new System.Windows.Forms.TextBox();
            this.fileInputLabel = new System.Windows.Forms.Label();
            this.fileInputBool = new System.Windows.Forms.CheckBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.folderChooser = new System.Windows.Forms.Button();
            this.fileChooser = new System.Windows.Forms.Button();
            this.maxBytes = new System.Windows.Forms.Label();
            this.outputDirectory = new System.Windows.Forms.TextBox();
            this.OutputDirectoryLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.TextBox();
            this.retrieveInput = new System.Windows.Forms.Button();
            this.filename = new System.Windows.Forms.TextBox();
            this.Read = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.bitCountReadLabel = new System.Windows.Forms.Label();
            this.bitCountRead = new System.Windows.Forms.NumericUpDown();
            this.trimBool = new System.Windows.Forms.CheckBox();
            this.fileOutputBool = new System.Windows.Forms.CheckBox();
            this.concatBool = new System.Windows.Forms.CheckBox();
            this.filename2 = new System.Windows.Forms.TextBox();
            this.fileChooser2 = new System.Windows.Forms.Button();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.LSBTab.SuspendLayout();
            this.Write.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bitCount)).BeginInit();
            this.Read.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bitCountRead)).BeginInit();
            this.SuspendLayout();
            // 
            // LSBTab
            // 
            this.LSBTab.Controls.Add(this.Write);
            this.LSBTab.Controls.Add(this.Read);
            this.LSBTab.Location = new System.Drawing.Point(13, 13);
            this.LSBTab.Name = "LSBTab";
            this.LSBTab.SelectedIndex = 0;
            this.LSBTab.Size = new System.Drawing.Size(235, 260);
            this.LSBTab.TabIndex = 0;
            // 
            // Write
            // 
            this.Write.Controls.Add(this.bitCountLabel);
            this.Write.Controls.Add(this.bitCount);
            this.Write.Controls.Add(this.endMarkBool);
            this.Write.Controls.Add(this.fileInputButton);
            this.Write.Controls.Add(this.fileInputFilename);
            this.Write.Controls.Add(this.fileInputLabel);
            this.Write.Controls.Add(this.fileInputBool);
            this.Write.Controls.Add(this.inputLabel);
            this.Write.Controls.Add(this.folderChooser);
            this.Write.Controls.Add(this.fileChooser);
            this.Write.Controls.Add(this.maxBytes);
            this.Write.Controls.Add(this.outputDirectory);
            this.Write.Controls.Add(this.OutputDirectoryLabel);
            this.Write.Controls.Add(this.MessageLabel);
            this.Write.Controls.Add(this.message);
            this.Write.Controls.Add(this.retrieveInput);
            this.Write.Controls.Add(this.filename);
            this.Write.Location = new System.Drawing.Point(4, 22);
            this.Write.Name = "Write";
            this.Write.Padding = new System.Windows.Forms.Padding(3);
            this.Write.Size = new System.Drawing.Size(227, 234);
            this.Write.TabIndex = 0;
            this.Write.Text = "Write";
            this.Write.UseVisualStyleBackColor = true;
            // 
            // bitCountLabel
            // 
            this.bitCountLabel.AutoSize = true;
            this.bitCountLabel.Location = new System.Drawing.Point(120, 97);
            this.bitCountLabel.Name = "bitCountLabel";
            this.bitCountLabel.Size = new System.Drawing.Size(61, 13);
            this.bitCountLabel.TabIndex = 27;
            this.bitCountLabel.Text = "Bits to Use:";
            // 
            // bitCount
            // 
            this.bitCount.Location = new System.Drawing.Point(187, 95);
            this.bitCount.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.bitCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bitCount.Name = "bitCount";
            this.bitCount.Size = new System.Drawing.Size(30, 20);
            this.bitCount.TabIndex = 26;
            this.bitCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bitCount.ValueChanged += new System.EventHandler(this.bitCount_ValueChanged);
            // 
            // endMarkBool
            // 
            this.endMarkBool.AutoSize = true;
            this.endMarkBool.Checked = true;
            this.endMarkBool.CheckState = System.Windows.Forms.CheckState.Checked;
            this.endMarkBool.Location = new System.Drawing.Point(6, 165);
            this.endMarkBool.Name = "endMarkBool";
            this.endMarkBool.Size = new System.Drawing.Size(220, 17);
            this.endMarkBool.TabIndex = 25;
            this.endMarkBool.Text = "End Marker(allows more efficient reading)";
            this.endMarkBool.UseVisualStyleBackColor = true;
            this.endMarkBool.Visible = false;
            // 
            // fileInputButton
            // 
            this.fileInputButton.Location = new System.Drawing.Point(188, 138);
            this.fileInputButton.Name = "fileInputButton";
            this.fileInputButton.Size = new System.Drawing.Size(30, 20);
            this.fileInputButton.TabIndex = 24;
            this.fileInputButton.Text = "...";
            this.fileInputButton.UseVisualStyleBackColor = true;
            this.fileInputButton.Visible = false;
            this.fileInputButton.Click += new System.EventHandler(this.fileInputButton_Click);
            // 
            // fileInputFilename
            // 
            this.fileInputFilename.Location = new System.Drawing.Point(7, 139);
            this.fileInputFilename.Name = "fileInputFilename";
            this.fileInputFilename.Size = new System.Drawing.Size(175, 20);
            this.fileInputFilename.TabIndex = 23;
            this.fileInputFilename.Visible = false;
            // 
            // fileInputLabel
            // 
            this.fileInputLabel.AutoSize = true;
            this.fileInputLabel.Location = new System.Drawing.Point(11, 123);
            this.fileInputLabel.Name = "fileInputLabel";
            this.fileInputLabel.Size = new System.Drawing.Size(78, 13);
            this.fileInputLabel.TabIndex = 22;
            this.fileInputLabel.Text = "File to Encode:";
            this.fileInputLabel.Visible = false;
            // 
            // fileInputBool
            // 
            this.fileInputBool.AutoSize = true;
            this.fileInputBool.Location = new System.Drawing.Point(6, 96);
            this.fileInputBool.Name = "fileInputBool";
            this.fileInputBool.Size = new System.Drawing.Size(68, 17);
            this.fileInputBool.TabIndex = 21;
            this.fileInputBool.Text = "From File";
            this.fileInputBool.UseVisualStyleBackColor = true;
            this.fileInputBool.CheckedChanged += new System.EventHandler(this.fileInputBool_CheckedChanged);
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
            // maxBytes
            // 
            this.maxBytes.AutoSize = true;
            this.maxBytes.Location = new System.Drawing.Point(121, 123);
            this.maxBytes.Name = "maxBytes";
            this.maxBytes.Size = new System.Drawing.Size(62, 13);
            this.maxBytes.TabIndex = 17;
            this.maxBytes.Text = "Max Bytes: ";
            // 
            // outputDirectory
            // 
            this.outputDirectory.Location = new System.Drawing.Point(6, 66);
            this.outputDirectory.Name = "outputDirectory";
            this.outputDirectory.Size = new System.Drawing.Size(175, 20);
            this.outputDirectory.TabIndex = 16;
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
            this.MessageLabel.Location = new System.Drawing.Point(11, 123);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(104, 13);
            this.MessageLabel.TabIndex = 14;
            this.MessageLabel.Text = "Message to encode:";
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(7, 139);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(211, 52);
            this.message.TabIndex = 12;
            // 
            // retrieveInput
            // 
            this.retrieveInput.AccessibleName = "";
            this.retrieveInput.Location = new System.Drawing.Point(80, 205);
            this.retrieveInput.Name = "retrieveInput";
            this.retrieveInput.Size = new System.Drawing.Size(75, 25);
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
            // 
            // Read
            // 
            this.Read.Controls.Add(this.label1);
            this.Read.Controls.Add(this.bitCountReadLabel);
            this.Read.Controls.Add(this.bitCountRead);
            this.Read.Controls.Add(this.trimBool);
            this.Read.Controls.Add(this.fileOutputBool);
            this.Read.Controls.Add(this.concatBool);
            this.Read.Controls.Add(this.filename2);
            this.Read.Controls.Add(this.fileChooser2);
            this.Read.Controls.Add(this.selectFileButton);
            this.Read.Location = new System.Drawing.Point(4, 22);
            this.Read.Name = "Read";
            this.Read.Padding = new System.Windows.Forms.Padding(3);
            this.Read.Size = new System.Drawing.Size(227, 234);
            this.Read.TabIndex = 1;
            this.Read.Text = "Read";
            this.Read.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Image to Read:";
            // 
            // bitCountReadLabel
            // 
            this.bitCountReadLabel.AutoSize = true;
            this.bitCountReadLabel.Location = new System.Drawing.Point(114, 126);
            this.bitCountReadLabel.Name = "bitCountReadLabel";
            this.bitCountReadLabel.Size = new System.Drawing.Size(68, 13);
            this.bitCountReadLabel.TabIndex = 28;
            this.bitCountReadLabel.Text = "Bits to Read:";
            // 
            // bitCountRead
            // 
            this.bitCountRead.Location = new System.Drawing.Point(187, 124);
            this.bitCountRead.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.bitCountRead.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bitCountRead.Name = "bitCountRead";
            this.bitCountRead.Size = new System.Drawing.Size(30, 20);
            this.bitCountRead.TabIndex = 27;
            this.bitCountRead.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // trimBool
            // 
            this.trimBool.AutoCheck = false;
            this.trimBool.AutoSize = true;
            this.trimBool.Checked = true;
            this.trimBool.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trimBool.Location = new System.Drawing.Point(6, 97);
            this.trimBool.Name = "trimBool";
            this.trimBool.Size = new System.Drawing.Size(189, 17);
            this.trimBool.TabIndex = 17;
            this.trimBool.Text = "Trim Excess Bytes (file output only)";
            this.trimBool.UseVisualStyleBackColor = true;
            // 
            // fileOutputBool
            // 
            this.fileOutputBool.AutoSize = true;
            this.fileOutputBool.Location = new System.Drawing.Point(6, 74);
            this.fileOutputBool.Name = "fileOutputBool";
            this.fileOutputBool.Size = new System.Drawing.Size(127, 17);
            this.fileOutputBool.TabIndex = 16;
            this.fileOutputBool.Text = "File Output (raw data)";
            this.fileOutputBool.UseVisualStyleBackColor = true;
            this.fileOutputBool.CheckedChanged += new System.EventHandler(this.fileOutputBool_CheckedChanged);
            // 
            // concatBool
            // 
            this.concatBool.AutoSize = true;
            this.concatBool.Checked = true;
            this.concatBool.CheckState = System.Windows.Forms.CheckState.Checked;
            this.concatBool.Location = new System.Drawing.Point(6, 50);
            this.concatBool.Name = "concatBool";
            this.concatBool.Size = new System.Drawing.Size(193, 17);
            this.concatBool.TabIndex = 15;
            this.concatBool.Text = "Cut Non-ASCII Text (only copyable)";
            this.concatBool.UseVisualStyleBackColor = true;
            // 
            // filename2
            // 
            this.filename2.Location = new System.Drawing.Point(6, 24);
            this.filename2.Name = "filename2";
            this.filename2.Size = new System.Drawing.Size(175, 20);
            this.filename2.TabIndex = 11;
            // 
            // fileChooser2
            // 
            this.fileChooser2.Location = new System.Drawing.Point(187, 24);
            this.fileChooser2.Name = "fileChooser2";
            this.fileChooser2.Size = new System.Drawing.Size(30, 20);
            this.fileChooser2.TabIndex = 13;
            this.fileChooser2.Text = "...";
            this.fileChooser2.UseVisualStyleBackColor = true;
            this.fileChooser2.Click += new System.EventHandler(this.fileChooser2_Click);
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(80, 205);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(75, 25);
            this.selectFileButton.TabIndex = 12;
            this.selectFileButton.Text = "Read";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // LSBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 286);
            this.Controls.Add(this.LSBTab);
            this.Name = "LSBForm";
            this.Text = "LSBForm";
            this.LSBTab.ResumeLayout(false);
            this.Write.ResumeLayout(false);
            this.Write.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bitCount)).EndInit();
            this.Read.ResumeLayout(false);
            this.Read.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bitCountRead)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl LSBTab;
        private System.Windows.Forms.TabPage Write;
        private System.Windows.Forms.TabPage Read;
        private System.Windows.Forms.Button folderChooser;
        private System.Windows.Forms.Button fileChooser;
        private System.Windows.Forms.Label maxBytes;
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
        private System.Windows.Forms.CheckBox concatBool;
        private System.Windows.Forms.CheckBox fileInputBool;
        private System.Windows.Forms.Button fileInputButton;
        private System.Windows.Forms.TextBox fileInputFilename;
        private System.Windows.Forms.Label fileInputLabel;
        private System.Windows.Forms.CheckBox fileOutputBool;
        private System.Windows.Forms.CheckBox trimBool;
        private System.Windows.Forms.CheckBox endMarkBool;
        private System.Windows.Forms.Label bitCountLabel;
        private System.Windows.Forms.NumericUpDown bitCount;
        private System.Windows.Forms.NumericUpDown bitCountRead;
        private System.Windows.Forms.Label bitCountReadLabel;
        private System.Windows.Forms.Label label1;
    }
}