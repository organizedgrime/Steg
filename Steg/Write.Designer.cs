namespace Steg
{
    partial class Write
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
            this.filename = new System.Windows.Forms.TextBox();
            this.retrieveInput = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.TextBox();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.OutputDirectoryLabel = new System.Windows.Forms.Label();
            this.outputDirectory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // filename
            // 
            this.filename.AccessibleName = "";
            this.filename.Location = new System.Drawing.Point(50, 35);
            this.filename.Name = "filename";
            this.filename.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.filename.Size = new System.Drawing.Size(175, 20);
            this.filename.TabIndex = 0;
            this.filename.Text = "C:\\Users\\Nico\\My Documents\\Visual Studio 2015\\Projects\\Steg\\lmao.png";
            this.filename.TextChanged += new System.EventHandler(this.filename_TextChanged);
            // 
            // retrieveInput
            // 
            this.retrieveInput.AccessibleName = "";
            this.retrieveInput.Location = new System.Drawing.Point(98, 227);
            this.retrieveInput.Name = "retrieveInput";
            this.retrieveInput.Size = new System.Drawing.Size(75, 23);
            this.retrieveInput.TabIndex = 1;
            this.retrieveInput.Text = "Write";
            this.retrieveInput.UseVisualStyleBackColor = true;
            this.retrieveInput.Click += new System.EventHandler(this.retrieveInput_Click);
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(50, 144);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(175, 77);
            this.message.TabIndex = 2;
            this.message.TextChanged += new System.EventHandler(this.message_TextChanged);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(47, 19);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(84, 13);
            this.FileNameLabel.TabIndex = 3;
            this.FileNameLabel.Text = "Input File Name:";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(51, 128);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(104, 13);
            this.MessageLabel.TabIndex = 4;
            this.MessageLabel.Text = "Message to encode:";
            // 
            // OutputDirectoryLabel
            // 
            this.OutputDirectoryLabel.AutoSize = true;
            this.OutputDirectoryLabel.Location = new System.Drawing.Point(54, 61);
            this.OutputDirectoryLabel.Name = "OutputDirectoryLabel";
            this.OutputDirectoryLabel.Size = new System.Drawing.Size(87, 13);
            this.OutputDirectoryLabel.TabIndex = 5;
            this.OutputDirectoryLabel.Text = "Output Directory:";
            // 
            // outputDirectory
            // 
            this.outputDirectory.Location = new System.Drawing.Point(50, 77);
            this.outputDirectory.Name = "outputDirectory";
            this.outputDirectory.Size = new System.Drawing.Size(175, 20);
            this.outputDirectory.TabIndex = 6;
            this.outputDirectory.Text = "C:\\Users\\Nico\\Desktop\\";
            // 
            // Write
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.outputDirectory);
            this.Controls.Add(this.OutputDirectoryLabel);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.message);
            this.Controls.Add(this.retrieveInput);
            this.Controls.Add(this.filename);
            this.Name = "Write";
            this.Text = "Write";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.Button retrieveInput;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label OutputDirectoryLabel;
        private System.Windows.Forms.TextBox outputDirectory;
    }
}

