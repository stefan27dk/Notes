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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.copy_all_button = new System.Windows.Forms.Button();
            this.scroll_to_top_button = new System.Windows.Forms.Button();
            this.scroll_to_bottom_button = new System.Windows.Forms.Button();
            this.today_button = new System.Windows.Forms.Button();
            this.to_do_button = new System.Windows.Forms.Button();
            this.words_count_label = new System.Windows.Forms.Label();
            this.print_button = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zoom_richtextbox_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form_opacity_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // main_richTextBox
            // 
            this.main_richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(158)))));
            this.main_richTextBox.EnableAutoDragDrop = true;
            this.main_richTextBox.HideSelection = false;
            this.main_richTextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.main_richTextBox.Location = new System.Drawing.Point(3, 97);
            this.main_richTextBox.MaxLength = 999999999;
            this.main_richTextBox.Name = "main_richTextBox";
            this.main_richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.main_richTextBox.ShowSelectionMargin = true;
            this.main_richTextBox.Size = new System.Drawing.Size(332, 216);
            this.main_richTextBox.TabIndex = 0;
            this.main_richTextBox.Text = "";
            this.main_richTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.main_richTextBox_LinkClicked);
            this.main_richTextBox.TextChanged += new System.EventHandler(this.main_richTextBox_TextChanged);
            this.main_richTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.main_richTextBox_KeyDown);
            this.main_richTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.main_richTextBox_KeyPress);
            this.main_richTextBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.main_richTextBox_MouseUp);
            // 
            // standart_view_button
            // 
            this.standart_view_button.BackgroundImage = global::Notes.Properties.Resources.computer_window;
            this.standart_view_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.standart_view_button.Location = new System.Drawing.Point(100, 1);
            this.standart_view_button.Name = "standart_view_button";
            this.standart_view_button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.standart_view_button.Size = new System.Drawing.Size(25, 25);
            this.standart_view_button.TabIndex = 1;
            this.standart_view_button.UseVisualStyleBackColor = true;
            this.standart_view_button.Click += new System.EventHandler(this.standart_view_button_Click);
            // 
            // new_note_button
            // 
            this.new_note_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.new_note_button.FlatAppearance.BorderSize = 0;
            this.new_note_button.Location = new System.Drawing.Point(1, -1);
            this.new_note_button.Name = "new_note_button";
            this.new_note_button.Size = new System.Drawing.Size(53, 42);
            this.new_note_button.TabIndex = 2;
            this.new_note_button.Text = "+";
            this.new_note_button.UseVisualStyleBackColor = false;
            this.new_note_button.Click += new System.EventHandler(this.new_note_button_Click);
            // 
            // start_on_startup_button
            // 
            this.start_on_startup_button.BackgroundImage = global::Notes.Properties.Resources.start;
            this.start_on_startup_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.start_on_startup_button.Location = new System.Drawing.Point(254, 31);
            this.start_on_startup_button.Name = "start_on_startup_button";
            this.start_on_startup_button.Size = new System.Drawing.Size(25, 25);
            this.start_on_startup_button.TabIndex = 3;
            this.start_on_startup_button.UseVisualStyleBackColor = true;
            this.start_on_startup_button.Click += new System.EventHandler(this.start_on_startup_button_Click);
            // 
            // chgange_collor_button
            // 
            this.chgange_collor_button.BackgroundImage = global::Notes.Properties.Resources.colors;
            this.chgange_collor_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chgange_collor_button.Location = new System.Drawing.Point(176, 31);
            this.chgange_collor_button.Name = "chgange_collor_button";
            this.chgange_collor_button.Size = new System.Drawing.Size(25, 25);
            this.chgange_collor_button.TabIndex = 4;
            this.chgange_collor_button.UseVisualStyleBackColor = true;
            this.chgange_collor_button.Click += new System.EventHandler(this.chgange_collor_button_Click);
            // 
            // align_txt_right_button
            // 
            this.align_txt_right_button.BackgroundImage = global::Notes.Properties.Resources.right_align1;
            this.align_txt_right_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.align_txt_right_button.Location = new System.Drawing.Point(61, 73);
            this.align_txt_right_button.Name = "align_txt_right_button";
            this.align_txt_right_button.Size = new System.Drawing.Size(25, 25);
            this.align_txt_right_button.TabIndex = 5;
            this.align_txt_right_button.UseVisualStyleBackColor = true;
            this.align_txt_right_button.Click += new System.EventHandler(this.align_txt_right_button_Click);
            // 
            // align_txt_middle_button
            // 
            this.align_txt_middle_button.BackgroundImage = global::Notes.Properties.Resources.align_center1;
            this.align_txt_middle_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.align_txt_middle_button.Location = new System.Drawing.Point(32, 73);
            this.align_txt_middle_button.Name = "align_txt_middle_button";
            this.align_txt_middle_button.Size = new System.Drawing.Size(25, 25);
            this.align_txt_middle_button.TabIndex = 6;
            this.align_txt_middle_button.UseVisualStyleBackColor = true;
            this.align_txt_middle_button.Click += new System.EventHandler(this.align_txt_middle_button_Click);
            // 
            // align_txt_left_button
            // 
            this.align_txt_left_button.BackgroundImage = global::Notes.Properties.Resources.align_left;
            this.align_txt_left_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.align_txt_left_button.Location = new System.Drawing.Point(2, 72);
            this.align_txt_left_button.Name = "align_txt_left_button";
            this.align_txt_left_button.Size = new System.Drawing.Size(25, 25);
            this.align_txt_left_button.TabIndex = 7;
            this.align_txt_left_button.UseVisualStyleBackColor = true;
            this.align_txt_left_button.Click += new System.EventHandler(this.align_txt_left_button_Click);
            // 
            // bold_button
            // 
            this.bold_button.Location = new System.Drawing.Point(89, 72);
            this.bold_button.Name = "bold_button";
            this.bold_button.Size = new System.Drawing.Size(25, 25);
            this.bold_button.TabIndex = 8;
            this.bold_button.Text = "B";
            this.bold_button.UseVisualStyleBackColor = true;
            this.bold_button.Click += new System.EventHandler(this.bold_button_Click);
            // 
            // Italic_button
            // 
            this.Italic_button.Location = new System.Drawing.Point(119, 72);
            this.Italic_button.Name = "Italic_button";
            this.Italic_button.Size = new System.Drawing.Size(25, 25);
            this.Italic_button.TabIndex = 9;
            this.Italic_button.Text = "I";
            this.Italic_button.UseVisualStyleBackColor = true;
            this.Italic_button.Click += new System.EventHandler(this.Italic_button_Click);
            // 
            // crossout_button
            // 
            this.crossout_button.BackgroundImage = global::Notes.Properties.Resources.cross_out;
            this.crossout_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.crossout_button.Location = new System.Drawing.Point(148, 72);
            this.crossout_button.Name = "crossout_button";
            this.crossout_button.Size = new System.Drawing.Size(25, 25);
            this.crossout_button.TabIndex = 10;
            this.crossout_button.UseVisualStyleBackColor = true;
            this.crossout_button.Click += new System.EventHandler(this.middleline_button_Click);
            // 
            // underline_button
            // 
            this.underline_button.Location = new System.Drawing.Point(179, 73);
            this.underline_button.Name = "underline_button";
            this.underline_button.Size = new System.Drawing.Size(25, 25);
            this.underline_button.TabIndex = 11;
            this.underline_button.Text = "U";
            this.underline_button.UseVisualStyleBackColor = true;
            this.underline_button.Click += new System.EventHandler(this.underline_button_Click);
            // 
            // endLine_button
            // 
            this.endLine_button.Location = new System.Drawing.Point(209, 73);
            this.endLine_button.Name = "endLine_button";
            this.endLine_button.Size = new System.Drawing.Size(25, 25);
            this.endLine_button.TabIndex = 12;
            this.endLine_button.Text = "→";
            this.endLine_button.UseVisualStyleBackColor = true;
            this.endLine_button.Click += new System.EventHandler(this.endLine_button_Click);
            // 
            // wrapText_button
            // 
            this.wrapText_button.Location = new System.Drawing.Point(272, 73);
            this.wrapText_button.Name = "wrapText_button";
            this.wrapText_button.Size = new System.Drawing.Size(25, 25);
            this.wrapText_button.TabIndex = 13;
            this.wrapText_button.Text = "W";
            this.wrapText_button.UseVisualStyleBackColor = true;
            this.wrapText_button.Click += new System.EventHandler(this.wrapText_button_Click);
            // 
            // margin_button
            // 
            this.margin_button.Location = new System.Drawing.Point(240, 73);
            this.margin_button.Name = "margin_button";
            this.margin_button.Size = new System.Drawing.Size(25, 25);
            this.margin_button.TabIndex = 14;
            this.margin_button.Text = "M";
            this.margin_button.UseVisualStyleBackColor = true;
            this.margin_button.Click += new System.EventHandler(this.margin_button_Click);
            // 
            // zoom_richtextbox_trackBar
            // 
            this.zoom_richtextbox_trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zoom_richtextbox_trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zoom_richtextbox_trackBar.Location = new System.Drawing.Point(222, 359);
            this.zoom_richtextbox_trackBar.Maximum = 100;
            this.zoom_richtextbox_trackBar.Minimum = 1;
            this.zoom_richtextbox_trackBar.Name = "zoom_richtextbox_trackBar";
            this.zoom_richtextbox_trackBar.Size = new System.Drawing.Size(104, 45);
            this.zoom_richtextbox_trackBar.TabIndex = 15;
            this.zoom_richtextbox_trackBar.TickFrequency = 20;
            this.zoom_richtextbox_trackBar.Value = 1;
            this.zoom_richtextbox_trackBar.ValueChanged += new System.EventHandler(this.zoom_richtextbox_trackBar_ValueChanged);
            // 
            // form_opacity_trackBar
            // 
            this.form_opacity_trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.form_opacity_trackBar.Location = new System.Drawing.Point(-4, 362);
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
            this.onTop_button.BackgroundImage = global::Notes.Properties.Resources.windows;
            this.onTop_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.onTop_button.Location = new System.Drawing.Point(72, 1);
            this.onTop_button.Name = "onTop_button";
            this.onTop_button.Size = new System.Drawing.Size(25, 25);
            this.onTop_button.TabIndex = 17;
            this.onTop_button.UseVisualStyleBackColor = true;
            this.onTop_button.Click += new System.EventHandler(this.onTop_button_Click);
            // 
            // save_button
            // 
            this.save_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save_button.BackgroundImage")));
            this.save_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save_button.Location = new System.Drawing.Point(145, 0);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(25, 25);
            this.save_button.TabIndex = 18;
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // load_all_notes_button
            // 
            this.load_all_notes_button.BackgroundImage = global::Notes.Properties.Resources.load;
            this.load_all_notes_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.load_all_notes_button.Location = new System.Drawing.Point(175, 0);
            this.load_all_notes_button.Name = "load_all_notes_button";
            this.load_all_notes_button.Size = new System.Drawing.Size(25, 25);
            this.load_all_notes_button.TabIndex = 19;
            this.load_all_notes_button.UseVisualStyleBackColor = true;
            this.load_all_notes_button.Click += new System.EventHandler(this.load_all_notes_button_Click);
            // 
            // open_folder_button
            // 
            this.open_folder_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("open_folder_button.BackgroundImage")));
            this.open_folder_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.open_folder_button.Location = new System.Drawing.Point(205, 1);
            this.open_folder_button.Name = "open_folder_button";
            this.open_folder_button.Size = new System.Drawing.Size(25, 25);
            this.open_folder_button.TabIndex = 20;
            this.open_folder_button.UseVisualStyleBackColor = true;
            this.open_folder_button.Click += new System.EventHandler(this.open_folder_button_Click);
            // 
            // close_all_forms_button
            // 
            this.close_all_forms_button.BackgroundImage = global::Notes.Properties.Resources.close;
            this.close_all_forms_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close_all_forms_button.Location = new System.Drawing.Point(254, 1);
            this.close_all_forms_button.Name = "close_all_forms_button";
            this.close_all_forms_button.Size = new System.Drawing.Size(25, 25);
            this.close_all_forms_button.TabIndex = 21;
            this.close_all_forms_button.UseVisualStyleBackColor = true;
            this.close_all_forms_button.Click += new System.EventHandler(this.close_all_forms_button_Click);
            // 
            // delete_note_button
            // 
            this.delete_note_button.BackgroundImage = global::Notes.Properties.Resources.delete;
            this.delete_note_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_note_button.Location = new System.Drawing.Point(286, 1);
            this.delete_note_button.Name = "delete_note_button";
            this.delete_note_button.Size = new System.Drawing.Size(25, 25);
            this.delete_note_button.TabIndex = 22;
            this.delete_note_button.UseVisualStyleBackColor = true;
            this.delete_note_button.Click += new System.EventHandler(this.delete_note_button_Click);
            // 
            // undo_button
            // 
            this.undo_button.BackgroundImage = global::Notes.Properties.Resources.undo;
            this.undo_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.undo_button.Location = new System.Drawing.Point(2, 41);
            this.undo_button.Name = "undo_button";
            this.undo_button.Size = new System.Drawing.Size(25, 25);
            this.undo_button.TabIndex = 23;
            this.undo_button.UseVisualStyleBackColor = true;
            this.undo_button.Click += new System.EventHandler(this.undo_button_Click);
            // 
            // char_index_label
            // 
            this.char_index_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.char_index_label.AutoSize = true;
            this.char_index_label.Location = new System.Drawing.Point(7, 322);
            this.char_index_label.Name = "char_index_label";
            this.char_index_label.Size = new System.Drawing.Size(67, 15);
            this.char_index_label.TabIndex = 24;
            this.char_index_label.Text = "Char Index:";
            // 
            // line_label
            // 
            this.line_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.line_label.AutoSize = true;
            this.line_label.Location = new System.Drawing.Point(83, 322);
            this.line_label.Name = "line_label";
            this.line_label.Size = new System.Drawing.Size(32, 15);
            this.line_label.TabIndex = 25;
            this.line_label.Text = "Line:";
            // 
            // copy_all_button
            // 
            this.copy_all_button.BackgroundImage = global::Notes.Properties.Resources.clipboard;
            this.copy_all_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.copy_all_button.Location = new System.Drawing.Point(145, 31);
            this.copy_all_button.Name = "copy_all_button";
            this.copy_all_button.Size = new System.Drawing.Size(25, 25);
            this.copy_all_button.TabIndex = 26;
            this.copy_all_button.UseVisualStyleBackColor = true;
            this.copy_all_button.Click += new System.EventHandler(this.copy_all_button_Click);
            // 
            // scroll_to_top_button
            // 
            this.scroll_to_top_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scroll_to_top_button.BackgroundImage = global::Notes.Properties.Resources.arrow_up;
            this.scroll_to_top_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.scroll_to_top_button.Location = new System.Drawing.Point(311, 73);
            this.scroll_to_top_button.Name = "scroll_to_top_button";
            this.scroll_to_top_button.Size = new System.Drawing.Size(25, 25);
            this.scroll_to_top_button.TabIndex = 27;
            this.scroll_to_top_button.UseVisualStyleBackColor = true;
            this.scroll_to_top_button.Click += new System.EventHandler(this.scroll_to_top_button_Click);
            // 
            // scroll_to_bottom_button
            // 
            this.scroll_to_bottom_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.scroll_to_bottom_button.BackgroundImage = global::Notes.Properties.Resources.arrow_down;
            this.scroll_to_bottom_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.scroll_to_bottom_button.Location = new System.Drawing.Point(311, 312);
            this.scroll_to_bottom_button.Name = "scroll_to_bottom_button";
            this.scroll_to_bottom_button.Size = new System.Drawing.Size(25, 25);
            this.scroll_to_bottom_button.TabIndex = 28;
            this.scroll_to_bottom_button.UseVisualStyleBackColor = true;
            this.scroll_to_bottom_button.Click += new System.EventHandler(this.scroll_to_bottom_button_Click);
            // 
            // today_button
            // 
            this.today_button.BackgroundImage = global::Notes.Properties.Resources.calendar;
            this.today_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.today_button.Location = new System.Drawing.Point(72, 32);
            this.today_button.Name = "today_button";
            this.today_button.Size = new System.Drawing.Size(25, 25);
            this.today_button.TabIndex = 29;
            this.today_button.UseVisualStyleBackColor = true;
            this.today_button.Click += new System.EventHandler(this.today_button_Click);
            // 
            // to_do_button
            // 
            this.to_do_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("to_do_button.BackgroundImage")));
            this.to_do_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.to_do_button.Location = new System.Drawing.Point(103, 32);
            this.to_do_button.Name = "to_do_button";
            this.to_do_button.Size = new System.Drawing.Size(25, 25);
            this.to_do_button.TabIndex = 30;
            this.to_do_button.UseVisualStyleBackColor = true;
            this.to_do_button.Click += new System.EventHandler(this.to_do_button_Click);
            // 
            // words_count_label
            // 
            this.words_count_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.words_count_label.AutoSize = true;
            this.words_count_label.Location = new System.Drawing.Point(130, 322);
            this.words_count_label.Name = "words_count_label";
            this.words_count_label.Size = new System.Drawing.Size(44, 15);
            this.words_count_label.TabIndex = 31;
            this.words_count_label.Text = "Words:";
            // 
            // print_button
            // 
            this.print_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("print_button.BackgroundImage")));
            this.print_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.print_button.Location = new System.Drawing.Point(209, 31);
            this.print_button.Name = "print_button";
            this.print_button.Size = new System.Drawing.Size(25, 25);
            this.print_button.TabIndex = 32;
            this.print_button.UseVisualStyleBackColor = true;
            this.print_button.Click += new System.EventHandler(this.print_button_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Notes.Properties.Resources.play_button_red;
            this.button1.Location = new System.Drawing.Point(288, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(335, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.print_button);
            this.Controls.Add(this.words_count_label);
            this.Controls.Add(this.to_do_button);
            this.Controls.Add(this.today_button);
            this.Controls.Add(this.scroll_to_bottom_button);
            this.Controls.Add(this.scroll_to_top_button);
            this.Controls.Add(this.copy_all_button);
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
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
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
        private Button copy_all_button;
        private Button scroll_to_top_button;
        private Button scroll_to_bottom_button;
        private Button today_button;
        private Button to_do_button;
        private Label words_count_label;
        private Button print_button;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button button1;
    }
}