using Microsoft.Win32;
using System.Diagnostics;
using System.IO;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Notes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string path = $"C:\\Notes\\";
        MainForm newForm;

        private void AlignTextLeft()
        {
            main_richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            main_richTextBox.Focus();
        }

        private void align_txt_left_button_Click(object sender, EventArgs e)
        {
            AlignTextLeft();
        }



        private void AlignTextMiddle()
        {
            main_richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            main_richTextBox.Focus();
        }


        private void align_txt_middle_button_Click(object sender, EventArgs e)
        {
            AlignTextMiddle();
        }




        private void AlignTextRight()
        {
            main_richTextBox.SelectionAlignment = HorizontalAlignment.Right;
            main_richTextBox.Focus();
        }


        private void align_txt_right_button_Click(object sender, EventArgs e)
        {
            AlignTextRight();
        }






        private void middleline_button_Click(object sender, EventArgs e)
        {
            ToggleMiddleline();
        }


        private void ToggleMiddleline()
        {
            if (main_richTextBox.SelectionFont.Style.ToString().Contains("Strikeout"))  
            {
                main_richTextBox.SelectionFont = new Font(main_richTextBox.SelectionFont, main_richTextBox.SelectionFont.Style & ~FontStyle.Strikeout);   
            }
            else  
            {
                main_richTextBox.SelectionFont = new Font(main_richTextBox.SelectionFont, main_richTextBox.SelectionFont.Style | FontStyle.Strikeout); 
            }
            main_richTextBox.Focus();
        }

        private void bold_button_Click(object sender, EventArgs e)
        {
            ToggleBold();
        }



        private void ToggleBold()
        {
            if (main_richTextBox.SelectionFont.Style.ToString().Contains("Bold")) //If the selected character is Bold
            {
                main_richTextBox.SelectionFont = new Font(main_richTextBox.SelectionFont, main_richTextBox.SelectionFont.Style & ~FontStyle.Bold);  //Make the selected character unBold
            }
            else //If the selected character is unBold
            {
                main_richTextBox.SelectionFont = new Font(main_richTextBox.SelectionFont, main_richTextBox.SelectionFont.Style | FontStyle.Bold);//Make the selected character Bold
            }
            main_richTextBox.Focus();
        }



        private void Italic_button_Click(object sender, EventArgs e)
        {
            ToggleItalic();
        }

        private void ToggleItalic()
        {
            if (main_richTextBox.SelectionFont.Style.ToString().Contains("Italic"))
            {
                main_richTextBox.SelectionFont = new Font(main_richTextBox.SelectionFont, main_richTextBox.SelectionFont.Style & ~FontStyle.Italic);
            }
            else
            {
                main_richTextBox.SelectionFont = new Font(main_richTextBox.SelectionFont, main_richTextBox.SelectionFont.Style | FontStyle.Italic);
            }
            main_richTextBox.Focus();
        }



        private void underline_button_Click(object sender, EventArgs e)
        {
            ToggleUnderline();
        }



        private void ToggleUnderline()
        {
            if (main_richTextBox.SelectionFont.Style.ToString().Contains("Underline"))
            {
                main_richTextBox.SelectionFont = new Font(main_richTextBox.SelectionFont, main_richTextBox.SelectionFont.Style & ~FontStyle.Underline);
            }
            else
            {
                main_richTextBox.SelectionFont = new Font(main_richTextBox.SelectionFont, main_richTextBox.SelectionFont.Style | FontStyle.Underline);
            }
            main_richTextBox.Focus();
        }




        private void SelectLine()
        {
            int firstcharindex = main_richTextBox.GetFirstCharIndexOfCurrentLine();

            int currentline = main_richTextBox.GetLineFromCharIndex(firstcharindex);

            string currentlinetext = main_richTextBox.Lines[currentline];

            main_richTextBox.Select(firstcharindex, currentlinetext.Length);



        }
        





        private void DublicateText()
        {
            //string selectionToDublicate = main_richTextBox.SelectedText;
            //// keep all values that will change
            //int oldStart = main_richTextBox.SelectionStart;
            //int oldLength = main_richTextBox.SelectionLength;

            //// 
            //main_richTextBox.SelectionStart = main_richTextBox.SelectionLength;
            //main_richTextBox.SelectionLength = 0;


            //// set the selection to the text to be inserted
            //main_richTextBox.SelectedText = selectionToDublicate;



            int firstcharindex = main_richTextBox.GetFirstCharIndexOfCurrentLine();


           
            int currentline = main_richTextBox.GetLineFromCharIndex(firstcharindex);
            string currentlinetext = main_richTextBox.Lines[currentline];




            main_richTextBox.Select(firstcharindex, currentlinetext.Length);

            main_richTextBox.SelectionStart = main_richTextBox.SelectionLength; // Move the curser after the selected text

            main_richTextBox.SelectionLength = 0; // Deselect the text


            // set the selection to the text to be inserted
            main_richTextBox.SelectedText = "\n" + currentlinetext; // Add New Line and insert the textx



        }



       private void LineNumberRun()
        {
            int firstcharindex = main_richTextBox.GetFirstCharIndexOfCurrentLine();
            int currentline = main_richTextBox.GetLineFromCharIndex(firstcharindex);
            main_richTextBox.SelectedText = "\n" + $"{currentline}"; // Add New Line and insert the textx
        }




        private void EndLine()
        {
            int firstcharindex = main_richTextBox.GetFirstCharIndexOfCurrentLine();


            int currentline = main_richTextBox.GetLineFromCharIndex(firstcharindex);
            string currentlinetext = main_richTextBox.Lines[currentline];


            main_richTextBox.Select(firstcharindex, currentlinetext.Length);

            main_richTextBox.SelectionStart += main_richTextBox.SelectionLength; // Move the curser after the selected text

            main_richTextBox.SelectionLength = 0; // Deselect the text
        }



        private void main_richTextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == (Keys.Control | Keys.I))
            {
                e.SuppressKeyPress = true;
                ToggleItalic();
            }
            else if (e.KeyData == (Keys.Control | Keys.U))
            {
                e.SuppressKeyPress = true;
                ToggleUnderline();
            }
            else if (e.KeyData == (Keys.Control | Keys.B))
            {
                e.SuppressKeyPress = true;
                ToggleBold();
            }
            else if (e.KeyData == (Keys.Control | Keys.K))
            {
                e.SuppressKeyPress = true;
                ToggleMiddleline();
            }
            else if (e.KeyData == (Keys.Alt | Keys.Left))
            {
                e.SuppressKeyPress = true;
                AlignTextLeft();
            }
            else if (e.KeyData == (Keys.Alt | Keys.Right))
            {
                e.SuppressKeyPress = true;
                AlignTextRight();
            }
            else if (e.KeyData == (Keys.Alt | Keys.Up))
            {
                e.SuppressKeyPress = true;
                AlignTextMiddle();
            }
            else if (e.KeyData == (Keys.Alt | Keys.Right))
            {
                e.SuppressKeyPress = true;
                AlignTextRight();
            }
            else if (e.KeyData == (Keys.Control | Keys.Q))
            {
                e.SuppressKeyPress = true;
                SelectLine();
            }
             else if (e.KeyData == (Keys.Control | Keys.D))
            {
                e.SuppressKeyPress = true;
                DublicateText();
            }
            else if (e.KeyData == (Keys.Control | Keys.W))
            {
                e.SuppressKeyPress = true;
                EndLine();
            }
           else if (e.KeyData == (Keys.Control | Keys.L))
            {
                e.SuppressKeyPress = true;
                LineNumberRun();
            }
          
        }





        private void MainForm_Load(object sender, EventArgs e)
        {
            int ScreenW = Screen.PrimaryScreen.Bounds.Width;
            this.Size = new Size(360, 400);
            this.Location = new Point((ScreenW) - (this.Width), 0); 
        }


        private void ReadAllNotes()
        {
            string[] filesArray = Directory.GetFiles(path);

            foreach (var file in filesArray)
            {
                new Thread(() =>
                {
                    var newNoteForm = new MainForm();
                    newNoteForm.main_richTextBox.LoadFile(file);
                    newNoteForm.Show();
                    Application.Run();
                }).Start();
            }
             

            
            
            //main_richTextBox.Text = File.ReadAllText(path); 
        }



        private void endLine_button_Click(object sender, EventArgs e)
        {
            EndLine();
            main_richTextBox.Focus();
        }

        private void wrapText_button_Click(object sender, EventArgs e)
        {
            if(main_richTextBox.WordWrap == true)
            {
                main_richTextBox.WordWrap = false;
            }
            else
            {
                main_richTextBox.WordWrap = true;
            }
        }




        private void margin_button_Click(object sender, EventArgs e)
        {
            main_richTextBox.RightMargin = main_richTextBox.Size.Width -35;
        }
 




        private void zoom_richtextbox_trackBar_ValueChanged(object sender, EventArgs e)
        {
            main_richTextBox.ZoomFactor = zoom_richtextbox_trackBar.Value;
        }




        private void form_opacity_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = form_opacity_trackBar.Value * 0.01;  // Adjust Form Opacity
        }



 


        private void onTop_button_Click(object sender, EventArgs e)
        {
            if (this.TopMost == false)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }



        private void CreatenewForm()
        {
            var x_loc = this.Location.X;
            var y_loc = this.Location.Y;
            new Thread(() =>
            {
                newForm = new MainForm();
                newForm.Location = new Point(x_loc + newForm.Width, y_loc + +newForm.Height);
                newForm.Show();
                Application.Run();
            }).Start();
            
        }



        private void new_note_button_Click(object sender, EventArgs e)
        {
            CreatenewForm();
        }




        private void standart_view_button_Click(object sender, EventArgs e)
        {
            int ScreenW = Screen.PrimaryScreen.Bounds.Width;

            this.Size = new Size(360, 400);
            this.Location = new Point((ScreenW) - (this.Width), 0);
        }



        private void SaveTextToFile()
        {
            string guiId = System.Guid.NewGuid().ToString();
            string fileName;

            if (main_richTextBox.Text.Length > 0) // If not empty
            {
              string txt = Regex.Replace(main_richTextBox.Text, " {2,}", " "); // Replace whitespaces if they are more than 2
               

                if(main_richTextBox.Text.Length >= 10) // If has 10 chars
                {
                    fileName = $"Note - {txt.Substring(0, 10) + "#" + guiId}.rtf"; 
                }
                else // If it has less than 10 chars
                {
                    fileName = $"Note - {txt.Substring(0, main_richTextBox.Text.Length) + "____" + guiId}.rtf"; 
                }

                Directory.CreateDirectory(path);
                main_richTextBox.SaveFile(path + fileName, RichTextBoxStreamType.RichText);
            }
        }







        private void save_button_Click(object sender, EventArgs e)
        {
            SaveTextToFile();
        }

        private void MainForm_Leave(object sender, EventArgs e)
        {
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTextToFile();
        }




        // The path to the key where Windows looks for startup applications
        RegistryKey regKeyStartup = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        bool runonStartup = true;





        private void start_on_startup_button_Click(object sender, EventArgs e)
        {
            if (runonStartup == true)
            {
                // Add the value in the registry so that the application runs at startup
                regKeyStartup.SetValue("Notes", Application.ExecutablePath);
                runonStartup = false;
            }
            else
            {
                // Remove the value from the registry so that the application doesn't start
                regKeyStartup.DeleteValue("Notes", false);
                runonStartup = true;
            }
        }




        private void load_all_notes_button_Click(object sender, EventArgs e)
        {
            ReadAllNotes();
        }




        private void open_folder_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", path);
        }



        private void CloseAllForms()
        { 
                Invoke(new Action(() => 
                {
                    System.Windows.Forms.Application.Exit();
                    System.Environment.Exit(1);

                }));
        }

        private void close_all_forms_button_Click(object sender, EventArgs e)
        { 
            CloseAllForms(); 
        }





            ////Shortcut keys -----KEY WATCHER- ----SHORTCUT KEYS----------------::START::------------------------------------------------------------------------------------
            //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
            //{ 

            //    if (keyData == (Keys.Control | Keys.U))
            //    {
            //        ToggleUnderline();

            //    }
            //    if (keyData == (Keys.Control | Keys.I))
            //    {
            //        //ToggleItalic();
            //    }
            //    if (keyData == (Keys.Control | Keys.K))
            //    {
            //        ToggleMiddleline();
            //    }
            //    if (keyData == (Keys.Control | Keys.B))
            //    {
            //        ToggleBold();
            //    }



            //    return base.ProcessCmdKey(ref msg, keyData);
            //}

            //Shortcut keys -----KEY WATCHER- ----SHORTCUT KEYS----------------::END::------------------------------------------------------------------------------------





        }
}