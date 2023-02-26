namespace Notes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

         

        private void align_txt_left_button_Click(object sender, EventArgs e)
        {
            main_richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            main_richTextBox.Focus();
        }

        private void align_txt_middle_button_Click(object sender, EventArgs e)
        {
            main_richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            main_richTextBox.Focus();
        }

        private void align_txt_right_button_Click(object sender, EventArgs e)
        {
            main_richTextBox.SelectionAlignment = HorizontalAlignment.Right;
            main_richTextBox.Focus();
        }

        private void middleline_button_Click(object sender, EventArgs e)
        {

        }

        private void bold_button_Click(object sender, EventArgs e)
        {
            if(main_richTextBox.SelectionFont.Style == FontStyle.Bold)
            {
                main_richTextBox.SelectionFont = new Font(main_richTextBox.Font, FontStyle.Regular);
            }
            else
            {
                main_richTextBox.SelectionFont = new Font(main_richTextBox.Font, FontStyle.Bold);
            }
            main_richTextBox.Focus();
        }

        private void Italic_button_Click(object sender, EventArgs e)
        {
            if (main_richTextBox.SelectionFont.Style == FontStyle.Italic)
            {
                main_richTextBox.SelectionFont = new Font(main_richTextBox.Font, FontStyle.Regular);
            }
            else
            {
                main_richTextBox.SelectionFont = new Font(main_richTextBox.Font, FontStyle.Italic);
            }
            main_richTextBox.Focus();
        }
    }
}