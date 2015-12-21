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
            // DisplayOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
    }
}