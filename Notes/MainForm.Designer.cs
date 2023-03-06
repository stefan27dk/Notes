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
            this.endLine_button = new System.Windows.Forms.Button();
            this.wrapText_button = new System.Windows.Forms.Button();
            this.margin_button = new System.Windows.Forms.Button();
            this.zoom_richtextbox_trackBar = new System.Windows.Forms.TrackBar();
            this.form_opacity_trackBar = new System.Windows.Forms.TrackBar();
            this.onTop_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.load_all_notes_button = new System.Windows.Forms.Button();
            this.open_folder_button = new System.Windows.Forms.Button();
            this.close_all_forms_button = new System.Windows.Forms.Button();
            this.delete_note_button = new System.Windows.Forms.Button();
            this.undo_button = new System.Windows.Forms.Button();
            this.char_index_label = new System.Windows.Forms.Label();
            this.line_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zoom_richtextbox_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form_opacity_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // main_richTextBox
            // 
            this.main_richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.main_richTextBox.EnableAutoDragDrop = true;
            this.main_richTextBox.HideSelection = false;
            this.main_richTextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.main_richTextBox.Location = new System.Drawing.Point(3, 69);
            this.main_richTextBox.MaxLength = 999999999;
            this.main_richTextBox.Name = "main_richTextBox";
            this.main_richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.main_richTextBox.ShowSelectionMargin = true;
            this.main_richTextBox.Size = new System.Drawing.Size(359, 402);
            this.main_richTextBox.TabIndex = 0;
            this.main_richTextBox.Text = "";
            this.main_richTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.main_richTextBox_KeyDown);
            this.main_richTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.main_richTextBox_KeyPress);
            this.main_richTextBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.main_richTextBox_MouseUp);
            // 
            // standart_view_button
            // 
            this.standart_view_button.Location = new System.Drawing.Point(74, 13);
            this.standart_view_button.Name = "standart_view_button";
            this.standart_view_button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.standart_view_button.Size = new System.Drawing.Size(40, 23);
            this.standart_view_button.TabIndex = 1;
            this.standart_view_button.Text = "▪";
            this.standart_view_button.UseVisualStyleBackColor = true;
            this.standart_view_button.Click += new System.EventHandler(this.standart_view_button_Click);
            // 
            // new_note_button
            // 
            this.new_note_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.new_note_button.Location = new System.Drawing.Point(3, 9);
            this.new_note_button.Name = "new_note_button";
            this.new_note_button.Size = new System.Drawing.Size(33, 28);
            this.new_note_button.TabIndex = 2;
            this.new_note_button.Text = "+";
            this.new_note_button.UseVisualStyleBackColor = false;
            this.new_note_button.Click += new System.EventHandler(this.new_note_button_Click);
            // 
            // start_on_startup_button
            // 
            this.start_on_startup_button.Location = new System.Drawing.Point(120, 13);
            this.start_on_startup_button.Name = "start_on_startup_button";
            this.start_on_startup_button.Size = new System.Drawing.Size(75, 23);
            this.start_on_startup_button.TabIndex = 3;
            this.start_on_startup_button.Text = "Startup";
            this.start_on_startup_button.UseVisualStyleBackColor = true;
            this.start_on_startup_button.Click += new System.EventHandler(this.start_on_startup_button_Click);
            // 
            // chgange_collor_button
            // 
            this.chgange_collor_button.Location = new System.Drawing.Point(201, 13);
            this.chgange_collor_button.Name = "chgange_collor_button";
            this.chgange_collor_button.Size = new System.Drawing.Size(75, 23);
            this.chgange_collor_button.TabIndex = 4;
            this.chgange_collor_button.Text = "Color";
            this.chgange_collor_button.UseVisualStyleBackColor = true;
            // 
            // align_txt_right_button
            // 
            this.align_txt_right_button.BackgroundImage = global::Notes.Properties.Resources.right_align1;
            this.align_txt_right_button.Location = new System.Drawing.Point(64, 42);
            this.align_txt_right_button.Name = "align_txt_right_button";
            this.align_txt_right_button.Size = new System.Drawing.Size(28, 27);
            this.align_txt_right_button.TabIndex = 5;
            this.align_txt_right_button.UseVisualStyleBackColor = true;
            this.align_txt_right_button.Click += new System.EventHandler(this.align_txt_right_button_Click);
            // 
            // align_txt_middle_button
            // 
            this.align_txt_middle_button.BackgroundImage = global::Notes.Properties.Resources.align_center1;
            this.align_txt_middle_button.Location = new System.Drawing.Point(35, 42);
            this.align_txt_middle_button.Name = "align_txt_middle_button";
            this.align_txt_middle_button.Size = new System.Drawing.Size(23, 27);
            this.align_txt_middle_button.TabIndex = 6;
            this.align_txt_middle_button.UseVisualStyleBackColor = true;
            this.align_txt_middle_button.Click += new System.EventHandler(this.align_txt_middle_button_Click);
            // 
            // align_txt_left_button
            // 
            this.align_txt_left_button.BackgroundImage = global::Notes.Properties.Resources.align_left;
            this.align_txt_left_button.Location = new System.Drawing.Point(5, 41);
            this.align_txt_left_button.Name = "align_txt_left_button";
            this.align_txt_left_button.Size = new System.Drawing.Size(24, 28);
            this.align_txt_left_button.TabIndex = 7;
            this.align_txt_left_button.UseVisualStyleBackColor = true;
            this.align_txt_left_button.Click += new System.EventHandler(this.align_txt_left_button_Click);
            // 
            // bold_button
            // 
            this.bold_button.Location = new System.Drawing.Point(92, 41);
            this.bold_button.Name = "bold_button";
            this.bold_button.Size = new System.Drawing.Size(24, 28);
            this.bold_button.TabIndex = 8;
            this.bold_button.Text = "B";
            this.bold_button.UseVisualStyleBackColor = true;
            this.bold_button.Click += new System.EventHandler(this.bold_button_Click);
            // 
            // Italic_button
            // 
            this.Italic_button.Location = new System.Drawing.Point(122, 41);
            this.Italic_button.Name = "Italic_button";
            this.Italic_button.Size = new System.Drawing.Size(23, 28);
            this.Italic_button.TabIndex = 9;
            this.Italic_button.Text = "I";
            this.Italic_button.UseVisualStyleBackColor = true;
            this.Italic_button.Click += new System.EventHandler(this.Italic_button_Click);
            // 
            // crossout_button
            // 
            this.crossout_button.BackgroundImage = global::Notes.Properties.Resources.cross_out;
            this.crossout_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.crossout_button.Location = new System.Drawing.Point(151, 41);
            this.crossout_button.Name = "crossout_button";
            this.crossout_button.Size = new System.Drawing.Size(25, 28);
            this.crossout_button.TabIndex = 10;
            this.crossout_button.UseVisualStyleBackColor = true;
            this.crossout_button.Click += new System.EventHandler(this.middleline_button_Click);
            // 
            // underline_button
            // 
            this.underline_button.Location = new System.Drawing.Point(182, 42);
            this.underline_button.Name = "underline_button";
            this.underline_button.Size = new System.Drawing.Size(24, 27);
            this.underline_button.TabIndex = 11;
            this.underline_button.Text = "U";
            this.underline_button.UseVisualStyleBackColor = true;
            this.underline_button.Click += new System.EventHandler(this.underline_button_Click);
            // 
            // endLine_button
            // 
            this.endLine_button.Location = new System.Drawing.Point(212, 42);
            this.endLine_button.Name = "endLine_button";
            this.endLine_button.Size = new System.Drawing.Size(25, 27);
            this.endLine_button.TabIndex = 12;
            this.endLine_button.Text = "→";
            this.endLine_button.UseVisualStyleBackColor = true;
            this.endLine_button.Click += new System.EventHandler(this.endLine_button_Click);
            // 
            // wrapText_button
            // 
            this.wrapText_button.Location = new System.Drawing.Point(274, 44);
            this.wrapText_button.Name = "wrapText_button";
            this.wrapText_button.Size = new System.Drawing.Size(23, 23);
            this.wrapText_button.TabIndex = 13;
            this.wrapText_button.Text = "W";
            this.wrapText_button.UseVisualStyleBackColor = true;
            this.wrapText_button.Click += new System.EventHandler(this.wrapText_button_Click);
            // 
            // margin_button
            // 
            this.margin_button.Location = new System.Drawing.Point(242, 44);
            this.margin_button.Name = "margin_button";
            this.margin_button.Size = new System.Drawing.Size(26, 23);
            this.margin_button.TabIndex = 14;
            this.margin_button.Text = "M";
            this.margin_button.UseVisualStyleBackColor = true;
            this.margin_button.Click += new System.EventHandler(this.margin_button_Click);
            // 
            // zoom_richtextbox_trackBar
            // 
            this.zoom_richtextbox_trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zoom_richtextbox_trackBar.Location = new System.Drawing.Point(242, 517);
            this.zoom_richtextbox_trackBar.Minimum = 1;
            this.zoom_richtextbox_trackBar.Name = "zoom_richtextbox_trackBar";
            this.zoom_richtextbox_trackBar.Size = new System.Drawing.Size(104, 45);
            this.zoom_richtextbox_trackBar.TabIndex = 15;
            this.zoom_richtextbox_trackBar.Value = 1;
            this.zoom_richtextbox_trackBar.ValueChanged += new System.EventHandler(this.zoom_richtextbox_trackBar_ValueChanged);
            // 
            // form_opacity_trackBar
            // 
            this.form_opacity_trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.form_opacity_trackBar.Location = new System.Drawing.Point(-4, 520);
            this.form_opacity_trackBar.Maximum = 100;
            this.form_opacity_trackBar.Minimum = 50;
            this.form_opacity_trackBar.Name = "form_opacity_trackBar";
            this.form_opacity_trackBar.Size = new System.Drawing.Size(104, 45);
            this.form_opacity_trackBar.TabIndex = 16;
            this.form_opacity_trackBar.Value = 100;
            this.form_opacity_trackBar.ValueChanged += new System.EventHandler(this.form_opacity_trackBar_ValueChanged);
            // 
            // onTop_button
            // 
            this.onTop_button.Location = new System.Drawing.Point(42, 9);
            this.onTop_button.Name = "onTop_button";
            this.onTop_button.Size = new System.Drawing.Size(26, 30);
            this.onTop_button.TabIndex = 17;
            this.onTop_button.Text = "■";
            this.onTop_button.UseVisualStyleBackColor = true;
            this.onTop_button.Click += new System.EventHandler(this.onTop_button_Click);
            // 
            // save_button
            // 
            this.save_button.BackgroundImage = global::Notes.Properties.Resources.save;
            this.save_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.save_button.Location = new System.Drawing.Point(280, 13);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(33, 23);
            this.save_button.TabIndex = 18;
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // load_all_notes_button
            // 
            this.load_all_notes_button.Location = new System.Drawing.Point(319, 12);
            this.load_all_notes_button.Name = "load_all_notes_button";
            this.load_all_notes_button.Size = new System.Drawing.Size(75, 23);
            this.load_all_notes_button.TabIndex = 19;
            this.load_all_notes_button.Text = "Load";
            this.load_all_notes_button.UseVisualStyleBackColor = true;
            this.load_all_notes_button.Click += new System.EventHandler(this.load_all_notes_button_Click);
            // 
            // open_folder_button
            // 
            this.open_folder_button.Location = new System.Drawing.Point(303, 49);
            this.open_folder_button.Name = "open_folder_button";
            this.open_folder_button.Size = new System.Drawing.Size(75, 23);
            this.open_folder_button.TabIndex = 20;
            this.open_folder_button.Text = "Folder";
            this.open_folder_button.UseVisualStyleBackColor = true;
            this.open_folder_button.Click += new System.EventHandler(this.open_folder_button_Click);
            // 
            // close_all_forms_button
            // 
            this.close_all_forms_button.Location = new System.Drawing.Point(170, -3);
            this.close_all_forms_button.Name = "close_all_forms_button";
            this.close_all_forms_button.Size = new System.Drawing.Size(75, 23);
            this.close_all_forms_button.TabIndex = 21;
            this.close_all_forms_button.Text = "Close All";
            this.close_all_forms_button.UseVisualStyleBackColor = true;
            this.close_all_forms_button.Click += new System.EventHandler(this.close_all_forms_button_Click);
            // 
            // delete_note_button
            // 
            this.delete_note_button.Location = new System.Drawing.Point(106, -6);
            this.delete_note_button.Name = "delete_note_button";
            this.delete_note_button.Size = new System.Drawing.Size(75, 23);
            this.delete_note_button.TabIndex = 22;
            this.delete_note_button.Text = "X";
            this.delete_note_button.UseVisualStyleBackColor = true;
            this.delete_note_button.Click += new System.EventHandler(this.delete_note_button_Click);
            // 
            // undo_button
            // 
            this.undo_button.Location = new System.Drawing.Point(42, -2);
            this.undo_button.Name = "undo_button";
            this.undo_button.Size = new System.Drawing.Size(75, 23);
            this.undo_button.TabIndex = 23;
            this.undo_button.Text = "Undo";
            this.undo_button.UseVisualStyleBackColor = true;
            this.undo_button.Click += new System.EventHandler(this.undo_button_Click);
            // 
            // char_index_label
            // 
            this.char_index_label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.char_index_label.AutoSize = true;
            this.char_index_label.Location = new System.Drawing.Point(133, 523);
            this.char_index_label.Name = "char_index_label";
            this.char_index_label.Size = new System.Drawing.Size(67, 15);
            this.char_index_label.TabIndex = 24;
            this.char_index_label.Text = "Char Index:";
            // 
            // line_label
            // 
            this.line_label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.line_label.AutoSize = true;
            this.line_label.Location = new System.Drawing.Point(133, 496);
            this.line_label.Name = "line_label";
            this.line_label.Size = new System.Drawing.Size(32, 15);
            this.line_label.TabIndex = 25;
            this.line_label.Text = "Line:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(355, 547);
            this.Controls.Add(this.line_label);
            this.Controls.Add(this.char_index_label);
            this.Controls.Add(this.undo_button);
            this.Controls.Add(this.delete_note_button);
            this.Controls.Add(this.close_all_forms_button);
            this.Controls.Add(this.open_folder_button);
            this.Controls.Add(this.load_all_notes_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.onTop_button);
            this.Controls.Add(this.form_opacity_trackBar);
            this.Controls.Add(this.zoom_richtextbox_trackBar);
            this.Controls.Add(this.margin_button);
            this.Controls.Add(this.wrapText_button);
            this.Controls.Add(this.endLine_button);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zoom_richtextbox_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form_opacity_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button endLine_button;
        private Button wrapText_button;
        private Button margin_button;
        private TrackBar zoom_richtextbox_trackBar;
        private TrackBar form_opacity_trackBar;
        private Button onTop_button;
        private Button save_button;
        private Button load_all_notes_button;
        private Button open_folder_button;
        private Button close_all_forms_button;
        private Button delete_note_button;
        private Button undo_button;
        private Label char_index_label;
        private Label line_label;
    }
}