namespace Steg
{
    partial class MethodChooser
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
            this.methodDropdown = new System.Windows.Forms.ComboBox();
            this.selectMethodButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // methodDropdown
            // 
            this.methodDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodDropdown.FormattingEnabled = true;
            this.methodDropdown.Items.AddRange(new object[] {
            "LSB Write",
            "LSB Read"});
            this.methodDropdown.Location = new System.Drawing.Point(35, 35);
            this.methodDropdown.Name = "methodDropdown";
            this.methodDropdown.Size = new System.Drawing.Size(146, 21);
            this.methodDropdown.TabIndex = 0;
            this.methodDropdown.SelectedIndexChanged += new System.EventHandler(this.methodDropdown_SelectedIndexChanged);
            // 
            // selectMethodButton
            // 
            this.selectMethodButton.Location = new System.Drawing.Point(187, 35);
            this.selectMethodButton.Name = "selectMethodButton";
            this.selectMethodButton.Size = new System.Drawing.Size(70, 21);
            this.selectMethodButton.TabIndex = 1;
            this.selectMethodButton.Text = "Select";
            this.selectMethodButton.UseVisualStyleBackColor = true;
            this.selectMethodButton.Click += new System.EventHandler(this.selectMethodButton_Click);
            // 
            // MethodChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.selectMethodButton);
            this.Controls.Add(this.methodDropdown);
            this.Name = "MethodChooser";
            this.Text = "MethodChooser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox methodDropdown;
        private System.Windows.Forms.Button selectMethodButton;
    }
}