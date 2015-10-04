namespace Steg
{
    partial class Read
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
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.filename = new System.Windows.Forms.TextBox();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(47, 19);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(84, 13);
            this.FileNameLabel.TabIndex = 0;
            this.FileNameLabel.Text = "Input File Name:";
            // 
            // filename
            // 
            this.filename.Location = new System.Drawing.Point(50, 35);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(130, 20);
            this.filename.TabIndex = 1;
            this.filename.Text = "C:\\Users\\Nico\\Desktop\\output.png";
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(186, 35);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(70, 20);
            this.selectFileButton.TabIndex = 2;
            this.selectFileButton.Text = "Select";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // Read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 112);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.FileNameLabel);
            this.Name = "Read";
            this.Text = "Read";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.Button selectFileButton;
    }
}