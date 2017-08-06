namespace AlphabetizeTool
{
    partial class MainForm
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.alphabetizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Location = new System.Drawing.Point(13, 13);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(459, 411);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.RichTextBoxTextChanged);
            // 
            // alphabetizeButton
            // 
            this.alphabetizeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.alphabetizeButton.Enabled = false;
            this.alphabetizeButton.Location = new System.Drawing.Point(205, 430);
            this.alphabetizeButton.Name = "alphabetizeButton";
            this.alphabetizeButton.Size = new System.Drawing.Size(75, 23);
            this.alphabetizeButton.TabIndex = 1;
            this.alphabetizeButton.Text = "Alphabetize";
            this.alphabetizeButton.UseVisualStyleBackColor = true;
            this.alphabetizeButton.Click += new System.EventHandler(this.AlphabetizeButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.alphabetizeButton);
            this.Controls.Add(this.richTextBox);
            this.MinimumSize = new System.Drawing.Size(320, 240);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alphabetizer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button alphabetizeButton;
    }
}

