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
            this.copyButton = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            this.fileType = new System.Windows.Forms.Label();
            this.embeddedFolderChooser = new System.Windows.Forms.Button();
            this.embeddedOutputDirectory = new System.Windows.Forms.TextBox();
            this.writeEmbeddedButton = new System.Windows.Forms.Button();
            this.fileSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(13, 13);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(110, 23);
            this.copyButton.TabIndex = 0;
            this.copyButton.Text = "Copy To Clipboard";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(13, 53);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(259, 196);
            this.outputText.TabIndex = 13;
            // 
            // fileType
            // 
            this.fileType.AutoSize = true;
            this.fileType.Location = new System.Drawing.Point(12, 9);
            this.fileType.Name = "fileType";
            this.fileType.Size = new System.Drawing.Size(25, 13);
            this.fileType.TabIndex = 14;
            this.fileType.Text = "filler";
            this.fileType.Visible = false;
            // 
            // embeddedFolderChooser
            // 
            this.embeddedFolderChooser.Location = new System.Drawing.Point(242, 53);
            this.embeddedFolderChooser.Name = "embeddedFolderChooser";
            this.embeddedFolderChooser.Size = new System.Drawing.Size(30, 20);
            this.embeddedFolderChooser.TabIndex = 21;
            this.embeddedFolderChooser.Text = "...";
            this.embeddedFolderChooser.UseVisualStyleBackColor = true;
            this.embeddedFolderChooser.Visible = false;
            this.embeddedFolderChooser.Click += new System.EventHandler(this.embeddedFolderChooser_Click);
            // 
            // embeddedOutputDirectory
            // 
            this.embeddedOutputDirectory.Location = new System.Drawing.Point(61, 54);
            this.embeddedOutputDirectory.Name = "embeddedOutputDirectory";
            this.embeddedOutputDirectory.Size = new System.Drawing.Size(175, 20);
            this.embeddedOutputDirectory.TabIndex = 20;
            this.embeddedOutputDirectory.Visible = false;
            // 
            // writeEmbeddedButton
            // 
            this.writeEmbeddedButton.Location = new System.Drawing.Point(61, 110);
            this.writeEmbeddedButton.Name = "writeEmbeddedButton";
            this.writeEmbeddedButton.Size = new System.Drawing.Size(103, 23);
            this.writeEmbeddedButton.TabIndex = 22;
            this.writeEmbeddedButton.Text = "Write to Directory";
            this.writeEmbeddedButton.UseVisualStyleBackColor = true;
            this.writeEmbeddedButton.Visible = false;
            this.writeEmbeddedButton.Click += new System.EventHandler(this.writeEmbeddedButton_Click);
            // 
            // fileSize
            // 
            this.fileSize.AutoSize = true;
            this.fileSize.Location = new System.Drawing.Point(13, 86);
            this.fileSize.Name = "fileSize";
            this.fileSize.Size = new System.Drawing.Size(36, 13);
            this.fileSize.TabIndex = 23;
            this.fileSize.Text = "Bytes:";
            this.fileSize.Visible = false;
            // 
            // DisplayOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.fileSize);
            this.Controls.Add(this.writeEmbeddedButton);
            this.Controls.Add(this.embeddedFolderChooser);
            this.Controls.Add(this.embeddedOutputDirectory);
            this.Controls.Add(this.fileType);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.copyButton);
            this.Name = "DisplayOutput";
            this.Text = "DisplayOutput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Label fileType;
        private System.Windows.Forms.Button embeddedFolderChooser;
        private System.Windows.Forms.TextBox embeddedOutputDirectory;
        private System.Windows.Forms.Button writeEmbeddedButton;
        private System.Windows.Forms.Label fileSize;
    }
}