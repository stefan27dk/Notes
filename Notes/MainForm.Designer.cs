namespace Notes
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.main_richTextBox = new RichTextBoxE();
            this.SuspendLayout();
            // 
            // main_richTextBox
            // 
            this.main_richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.main_richTextBox.Location = new System.Drawing.Point(0, 39);
            this.main_richTextBox.Name = "main_richTextBox";
            this.main_richTextBox.Size = new System.Drawing.Size(354, 409);
            this.main_richTextBox.TabIndex = 0;
            this.main_richTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 450);
            this.Controls.Add(this.main_richTextBox);
            this.Name = "MainForm";
            this.Text = "Notes";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox main_richTextBox;
    }
}