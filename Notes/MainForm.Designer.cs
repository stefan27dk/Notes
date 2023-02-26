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
            this.standart_view_button = new System.Windows.Forms.Button();
            this.new_note_button = new System.Windows.Forms.Button();
            this.start_on_startup_button = new System.Windows.Forms.Button();
            this.chgange_collor_button = new System.Windows.Forms.Button();
            this.align_txt_right_button = new System.Windows.Forms.Button();
            this.align_txt_middle_button = new System.Windows.Forms.Button();
            this.align_txt_left_button = new System.Windows.Forms.Button();
            this.bold_button = new System.Windows.Forms.Button();
            this.Italic_button = new System.Windows.Forms.Button();
            this.crossout_button = new System.Windows.Forms.Button();
            this.underline_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // main_richTextBox
            // 
            this.main_richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.main_richTextBox.EnableAutoDragDrop = true;
            this.main_richTextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.main_richTextBox.Location = new System.Drawing.Point(-2, 100);
            this.main_richTextBox.MaxLength = 999999999;
            this.main_richTextBox.Name = "main_richTextBox";
            this.main_richTextBox.ShowSelectionMargin = true;
            this.main_richTextBox.Size = new System.Drawing.Size(354, 346);
            this.main_richTextBox.TabIndex = 0;
            this.main_richTextBox.Text = "";
            this.main_richTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.main_richTextBox_KeyDown);
            // 
            // standart_view_button
            // 
            this.standart_view_button.Location = new System.Drawing.Point(10, 14);
            this.standart_view_button.Name = "standart_view_button";
            this.standart_view_button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.standart_view_button.Size = new System.Drawing.Size(75, 23);
            this.standart_view_button.TabIndex = 1;
            this.standart_view_button.Text = "SV";
            this.standart_view_button.UseVisualStyleBackColor = true;
            // 
            // new_note_button
            // 
            this.new_note_button.Location = new System.Drawing.Point(88, 16);
            this.new_note_button.Name = "new_note_button";
            this.new_note_button.Size = new System.Drawing.Size(75, 23);
            this.new_note_button.TabIndex = 2;
            this.new_note_button.Text = "+";
            this.new_note_button.UseVisualStyleBackColor = true;
            // 
            // start_on_startup_button
            // 
            this.start_on_startup_button.Location = new System.Drawing.Point(169, 16);
            this.start_on_startup_button.Name = "start_on_startup_button";
            this.start_on_startup_button.Size = new System.Drawing.Size(75, 23);
            this.start_on_startup_button.TabIndex = 3;
            this.start_on_startup_button.Text = "Startup";
            this.start_on_startup_button.UseVisualStyleBackColor = true;
            // 
            // chgange_collor_button
            // 
            this.chgange_collor_button.Location = new System.Drawing.Point(250, 16);
            this.chgange_collor_button.Name = "chgange_collor_button";
            this.chgange_collor_button.Size = new System.Drawing.Size(75, 23);
            this.chgange_collor_button.TabIndex = 4;
            this.chgange_collor_button.Text = "Color";
            this.chgange_collor_button.UseVisualStyleBackColor = true;
            // 
            // align_txt_right_button
            // 
            this.align_txt_right_button.Location = new System.Drawing.Point(166, 71);
            this.align_txt_right_button.Name = "align_txt_right_button";
            this.align_txt_right_button.Size = new System.Drawing.Size(75, 23);
            this.align_txt_right_button.TabIndex = 5;
            this.align_txt_right_button.Text = "Right";
            this.align_txt_right_button.UseVisualStyleBackColor = true;
            this.align_txt_right_button.Click += new System.EventHandler(this.align_txt_right_button_Click);
            // 
            // align_txt_middle_button
            // 
            this.align_txt_middle_button.Location = new System.Drawing.Point(85, 71);
            this.align_txt_middle_button.Name = "align_txt_middle_button";
            this.align_txt_middle_button.Size = new System.Drawing.Size(75, 23);
            this.align_txt_middle_button.TabIndex = 6;
            this.align_txt_middle_button.Text = "Middle";
            this.align_txt_middle_button.UseVisualStyleBackColor = true;
            this.align_txt_middle_button.Click += new System.EventHandler(this.align_txt_middle_button_Click);
            // 
            // align_txt_left_button
            // 
            this.align_txt_left_button.Location = new System.Drawing.Point(6, 70);
            this.align_txt_left_button.Name = "align_txt_left_button";
            this.align_txt_left_button.Size = new System.Drawing.Size(75, 23);
            this.align_txt_left_button.TabIndex = 7;
            this.align_txt_left_button.Text = "Left";
            this.align_txt_left_button.UseVisualStyleBackColor = true;
            this.align_txt_left_button.Click += new System.EventHandler(this.align_txt_left_button_Click);
            // 
            // bold_button
            // 
            this.bold_button.Location = new System.Drawing.Point(250, 71);
            this.bold_button.Name = "bold_button";
            this.bold_button.Size = new System.Drawing.Size(75, 23);
            this.bold_button.TabIndex = 8;
            this.bold_button.Text = "Bold";
            this.bold_button.UseVisualStyleBackColor = true;
            this.bold_button.Click += new System.EventHandler(this.bold_button_Click);
            // 
            // Italic_button
            // 
            this.Italic_button.Location = new System.Drawing.Point(268, 45);
            this.Italic_button.Name = "Italic_button";
            this.Italic_button.Size = new System.Drawing.Size(75, 23);
            this.Italic_button.TabIndex = 9;
            this.Italic_button.Text = "I";
            this.Italic_button.UseVisualStyleBackColor = true;
            this.Italic_button.Click += new System.EventHandler(this.Italic_button_Click);
            // 
            // crossout_button
            // 
            this.crossout_button.Location = new System.Drawing.Point(153, 40);
            this.crossout_button.Name = "crossout_button";
            this.crossout_button.Size = new System.Drawing.Size(98, 23);
            this.crossout_button.TabIndex = 10;
            this.crossout_button.Text = "Middle Line";
            this.crossout_button.UseVisualStyleBackColor = true;
            this.crossout_button.Click += new System.EventHandler(this.middleline_button_Click);
            // 
            // underline_button
            // 
            this.underline_button.Location = new System.Drawing.Point(48, 45);
            this.underline_button.Name = "underline_button";
            this.underline_button.Size = new System.Drawing.Size(75, 23);
            this.underline_button.TabIndex = 11;
            this.underline_button.Text = "Underline";
            this.underline_button.UseVisualStyleBackColor = true;
            this.underline_button.Click += new System.EventHandler(this.underline_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 450);
            this.Controls.Add(this.underline_button);
            this.Controls.Add(this.crossout_button);
            this.Controls.Add(this.Italic_button);
            this.Controls.Add(this.bold_button);
            this.Controls.Add(this.align_txt_left_button);
            this.Controls.Add(this.align_txt_middle_button);
            this.Controls.Add(this.align_txt_right_button);
            this.Controls.Add(this.chgange_collor_button);
            this.Controls.Add(this.start_on_startup_button);
            this.Controls.Add(this.new_note_button);
            this.Controls.Add(this.standart_view_button);
            this.Controls.Add(this.main_richTextBox);
            this.Name = "MainForm";
            this.Text = "Notes";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBoxE main_richTextBox;
        private Button standart_view_button;
        private Button new_note_button;
        private Button start_on_startup_button;
        private Button chgange_collor_button;
        private Button align_txt_right_button;
        private Button align_txt_middle_button;
        private Button align_txt_left_button;
        private Button bold_button;
        private Button Italic_button;
        private Button crossout_button;
        private Button underline_button;
    }
}