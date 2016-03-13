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
            this.inputLabel = new System.Windows.Forms.Label();
            this.folderChooser = new System.Windows.Forms.Button();
            this.fileChooser = new System.Windows.Forms.Button();
            this.outputDirectory = new System.Windows.Forms.TextBox();
            this.OutputDirectoryLabel = new System.Windows.Forms.Label();
            this.retrieveInput = new System.Windows.Forms.Button();
            this.filename = new System.Windows.Forms.TextBox();
            this.PILabel = new System.Windows.Forms.Label();
            this.brightnessBar = new System.Windows.Forms.TrackBar();
            this.Brightness = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessBar)).BeginInit();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(31, 31);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(66, 13);
            this.inputLabel.TabIndex = 27;
            this.inputLabel.Text = "Input Image:";
            // 
            // folderChooser
            // 
            this.folderChooser.Location = new System.Drawing.Point(205, 91);
            this.folderChooser.Name = "folderChooser";
            this.folderChooser.Size = new System.Drawing.Size(30, 20);
            this.folderChooser.TabIndex = 26;
            this.folderChooser.Text = "...";
            this.folderChooser.UseVisualStyleBackColor = true;
            this.folderChooser.Click += new System.EventHandler(this.folderChooser_Click);
            // 
            // fileChooser
            // 
            this.fileChooser.Location = new System.Drawing.Point(205, 50);
            this.fileChooser.Name = "fileChooser";
            this.fileChooser.Size = new System.Drawing.Size(30, 20);
            this.fileChooser.TabIndex = 25;
            this.fileChooser.Text = "...";
            this.fileChooser.UseVisualStyleBackColor = true;
            this.fileChooser.Click += new System.EventHandler(this.fileChooser_Click);
            // 
            // outputDirectory
            // 
            this.outputDirectory.Location = new System.Drawing.Point(24, 92);
            this.outputDirectory.Name = "outputDirectory";
            this.outputDirectory.Size = new System.Drawing.Size(175, 20);
            this.outputDirectory.TabIndex = 24;
            // 
            // OutputDirectoryLabel
            // 
            this.OutputDirectoryLabel.AutoSize = true;
            this.OutputDirectoryLabel.Location = new System.Drawing.Point(28, 76);
            this.OutputDirectoryLabel.Name = "OutputDirectoryLabel";
            this.OutputDirectoryLabel.Size = new System.Drawing.Size(87, 13);
            this.OutputDirectoryLabel.TabIndex = 23;
            this.OutputDirectoryLabel.Text = "Output Directory:";
            // 
            // retrieveInput
            // 
            this.retrieveInput.AccessibleName = "";
            this.retrieveInput.Location = new System.Drawing.Point(84, 185);
            this.retrieveInput.Name = "retrieveInput";
            this.retrieveInput.Size = new System.Drawing.Size(75, 25);
            this.retrieveInput.TabIndex = 22;
            this.retrieveInput.Text = "Write";
            this.retrieveInput.UseVisualStyleBackColor = true;
            this.retrieveInput.Click += new System.EventHandler(this.retrieveInput_Click);
            // 
            // filename
            // 
            this.filename.AccessibleName = "";
            this.filename.Location = new System.Drawing.Point(24, 50);
            this.filename.Name = "filename";
            this.filename.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.filename.Size = new System.Drawing.Size(175, 20);
            this.filename.TabIndex = 21;
            // 
            // PILabel
            // 
            this.PILabel.AutoSize = true;
            this.PILabel.Location = new System.Drawing.Point(13, 13);
            this.PILabel.Name = "PILabel";
            this.PILabel.Size = new System.Drawing.Size(146, 13);
            this.PILabel.TabIndex = 28;
            this.PILabel.Text = "Choose an image to make PI!";
            // 
            // brightnessBar
            // 
            this.brightnessBar.LargeChange = 10;
            this.brightnessBar.Location = new System.Drawing.Point(24, 134);
            this.brightnessBar.Maximum = 100;
            this.brightnessBar.Name = "brightnessBar";
            this.brightnessBar.Size = new System.Drawing.Size(175, 45);
            this.brightnessBar.SmallChange = 10;
            this.brightnessBar.TabIndex = 29;
            this.brightnessBar.TickFrequency = 10;
            this.brightnessBar.Value = 80;
            // 
            // Brightness
            // 
            this.Brightness.AutoSize = true;
            this.Brightness.Location = new System.Drawing.Point(31, 115);
            this.Brightness.Name = "Brightness";
            this.Brightness.Size = new System.Drawing.Size(56, 13);
            this.Brightness.TabIndex = 30;
            this.Brightness.Text = "Brightness";
            // 
            // LSBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 220);
            this.Controls.Add(this.Brightness);
            this.Controls.Add(this.brightnessBar);
            this.Controls.Add(this.PILabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.folderChooser);
            this.Controls.Add(this.fileChooser);
            this.Controls.Add(this.outputDirectory);
            this.Controls.Add(this.OutputDirectoryLabel);
            this.Controls.Add(this.retrieveInput);
            this.Controls.Add(this.filename);
            this.MaximizeBox = false;
            this.Name = "LSBForm";
            this.Text = "PI Maker";
            ((System.ComponentModel.ISupportInitialize)(this.brightnessBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label inputLabel;
        private Button folderChooser;
        private Button fileChooser;
        private TextBox outputDirectory;
        private Label OutputDirectoryLabel;
        private Button retrieveInput;
        private TextBox filename;
        private Label PILabel;
        private TrackBar brightnessBar;
        private Label Brightness;
    }
}