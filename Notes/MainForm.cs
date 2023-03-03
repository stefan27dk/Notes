using Microsoft.Win32;
using Notes.Models;
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

       
        Stack<UndoRedoModel> undoList = new Stack<UndoRedoModel>();
        Stack<UndoRedoModel> redoList = new Stack<UndoRedoModel>();
        Stack<UndoTypeModel> undoTypeList = new Stack<UndoTypeModel>();

        string path = $"C:\\Notes\\";
        string fileName = "";
        bool save = true;
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

 
            bool isWrap = main_richTextBox.WordWrap;

            int firstcharindex = main_richTextBox.GetFirstCharIndexOfCurrentLine();
           
            main_richTextBox.WordWrap = false;
          

            int currentline = main_richTextBox.GetLineFromCharIndex(firstcharindex);
            string currentlinetext = main_richTextBox.Lines[currentline];


            main_richTextBox.Select(firstcharindex, currentlinetext.Length);

            //main_richTextBox.SelectionStart = main_richTextBox.SelectionLength; // Move the curser after the selected text

            // set the selection to the text to be inserted
            main_richTextBox.SelectedText = currentlinetext + "\n" + currentlinetext; // Add New Line and insert the textx

            main_richTextBox.SelectionLength = 0; // Deselect the text
 

            if (isWrap)
            {
                main_richTextBox.WordWrap = true;
                
            }

        }





        private void EnterNewLineBefore()
        {
            int firstcharindex = main_richTextBox.GetFirstCharIndexOfCurrentLine();



            int currentline = main_richTextBox.GetLineFromCharIndex(firstcharindex);
            string currentlinetext = main_richTextBox.Lines[currentline]; 
            main_richTextBox.Select(firstcharindex, currentlinetext.Length); 
            // Set the selection to the text to be inserted
            main_richTextBox.SelectedText = "\n" + currentlinetext; // Add New Line and insert the textx
        }







        private void EnterNewLineBeforeAndMoveCursor()
        {
            int firstcharindex = main_richTextBox.GetFirstCharIndexOfCurrentLine();



            int currentline = main_richTextBox.GetLineFromCharIndex(firstcharindex);
            string currentlinetext = main_richTextBox.Lines[currentline];




            main_richTextBox.Select(firstcharindex, currentlinetext.Length);

            //main_richTextBox.SelectionStart = main_richTextBox.SelectionLength; // Move the curser after the selected text

            // // Deselect the text


            // set the selection to the text to be inserted

            main_richTextBox.SelectionLength = 0;
            main_richTextBox.SelectedText = "\n"; // Add New Line and insert the textx
            main_richTextBox.Select(firstcharindex, currentlinetext.Length);
            main_richTextBox.SelectionLength = 0;




        }



        private void StartLine()
        {
            int firstcharindex = main_richTextBox.GetFirstCharIndexOfCurrentLine();

            int currentline = main_richTextBox.GetLineFromCharIndex(firstcharindex);
            string currentlinetext = main_richTextBox.Lines[currentline];

            main_richTextBox.Select(firstcharindex, currentlinetext.Length);

            //main_richTextBox.SelectionStart = main_richTextBox.SelectionLength; // Move the curser after the selected text

            // // Deselect the text


            // set the selection to the text to be inserted

            main_richTextBox.SelectionLength = 0;
            
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


        private void DeleteCurrentLine()
        {
           
                //// Get Line 
                //int firstCharIndex = main_richTextBox.GetFirstCharIndexOfCurrentLine();
                //int currentLine = main_richTextBox.GetLineFromCharIndex(firstCharIndex); // The Line

                //main_richTextBox.SelectionStart = main_richTextBox.GetFirstCharIndexFromLine(currentLine);
                //main_richTextBox.SelectionLength = this.main_richTextBox.Lines[currentLine].Length + 1;
                //this.main_richTextBox.SelectedText = String.Empty;


 

                // Get Line 
                int firstCharIndex = main_richTextBox.GetFirstCharIndexOfCurrentLine();
                int currentLine = main_richTextBox.GetLineFromCharIndex(firstCharIndex); // The Line

                main_richTextBox.SelectionStart = firstCharIndex;
                main_richTextBox.SelectionLength = this.main_richTextBox.Lines[currentLine].Length + 1;
                this.main_richTextBox.SelectedText = String.Empty;
             
        }


   



        private void main_richTextBox_KeyDown(object sender, KeyEventArgs e)
        {

            
            UndoRedoModel undoRedoObj = new UndoRedoModel();
            // Get Line 
            int firstCharIndex = main_richTextBox.GetFirstCharIndexOfCurrentLine();
            int currentLine = main_richTextBox.GetLineFromCharIndex(firstCharIndex); // The Line


            // Undo function ------------------------------------------------------------------
            if (e.KeyData == Keys.Back) // Add CTRL + X  "CUT when doing cut add to undo list"
            {
                //string currentlinetext = main_richTextBox.Lines[currentline];

                // !!!! Add here if selection lngth > 1 dont select
                if (main_richTextBox.SelectionLength == 0) // If there is no selection
                {
                    main_richTextBox.Select(main_richTextBox.SelectionStart - 1, 1); // Select the char in front of the caret
                }
                
                undoRedoObj.Line = currentLine;
                undoRedoObj.CharIndex = main_richTextBox.SelectionStart;
                undoRedoObj.Action = "Backspace";
                undoRedoObj.DeletedTxt = main_richTextBox.SelectedText; 

                undoList.Push(undoRedoObj);

            }
            else if (e.KeyData == (Keys.Control | Keys.X))
            {

                //string currentlinetext = main_richTextBox.Lines[currentline];
             
                if (main_richTextBox.SelectionLength != 0) // If there is selection
                {  
                    undoRedoObj.Line = currentLine;
                    undoRedoObj.CharIndex = main_richTextBox.SelectionStart;
                    undoRedoObj.Action = "Cut";
                    undoRedoObj.DeletedTxt = main_richTextBox.SelectedText;
                    undoList.Push(undoRedoObj);
                }
            }
            else if (e.KeyData == Keys.Delete)
            {
               
                //string currentlinetext = main_richTextBox.Lines[currentline];

                // !!!! Add here if selection lngth > 1 dont select
                if (main_richTextBox.SelectionLength == 0) // If there is no selection
                {
                    main_richTextBox.Select(main_richTextBox.SelectionStart, 1); // Select the char after the caret
                }

 
                undoRedoObj.Line = currentLine;
                undoRedoObj.CharIndex = main_richTextBox.SelectionStart;
                undoRedoObj.Action = "Del";
                undoRedoObj.DeletedTxt = main_richTextBox.SelectedText; 

                undoList.Push(undoRedoObj);
            }
            else if (e.KeyData == Keys.Enter)
            {
                //main_richTextBox.SelectionLength = main_richTextBox.Lines[currentLine].Length + 1;
                //main_richTextBox.SelectedText = String.Empty;

                //string currentlinetext = main_richTextBox.Lines[currentline];

         
                if (main_richTextBox.SelectionLength == 0) // If there is no selection
                {
                    //main_richTextBox.Select(main_richTextBox.SelectionStart, 0); // Select the char after the caret
                    undoRedoObj.Line = currentLine;
                    undoRedoObj.CharIndex = main_richTextBox.SelectionStart;
                    undoRedoObj.Action = "Enter";
                    undoRedoObj.DeletedTxt = ""; 
                    undoRedoObj.SelectionLength = 1; 
                    undoList.Push(undoRedoObj);
                }
                else
                { 
                    undoRedoObj.Line = currentLine;
                    undoRedoObj.CharIndex = main_richTextBox.SelectionStart;
                    undoRedoObj.Action = "EnterSelection";
                    undoRedoObj.DeletedTxt = main_richTextBox.SelectedText;
                    undoRedoObj.SelectionLength = 1;
                    undoList.Push(undoRedoObj);
                }
               
            }



          



            // Key Shortcuts --------------------------------------------------------
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
            else if (e.KeyData == (Keys.Control | Keys.G))
            {
                e.SuppressKeyPress = true;
                StartLine();
            }
            else if (e.KeyData == (Keys.Control | Keys.L))
            {
                e.SuppressKeyPress = true;
                LineNumberRun();
            } 
            else if (e.KeyData == (Keys.Control | Keys.Enter))
            {
                e.SuppressKeyPress = true;
                EnterNewLineBefore();
            }
            else if (e.KeyData == (Keys.Control | Keys.Shift | Keys.Enter))
            {
                e.SuppressKeyPress = true;
                EnterNewLineBeforeAndMoveCursor();
            }  
            else if (e.KeyData == (Keys.Control | Keys.Z))
            {
                e.SuppressKeyPress = true;
                UndoTxt();
            }
            else if (e.KeyData == (Keys.Control | Keys.X))
            {
                if (main_richTextBox.SelectionLength == 0)
                {
                    e.SuppressKeyPress = true;
                    DeleteCurrentLine();
                }
            }
            else if(char.IsLetter(Convert.ToChar(e.KeyCode)) || char.IsNumber(Convert.ToChar(e.KeyCode)))
            {
                // Undo add to list if there is selected text and any key letter or number is pressed and has replaced the text with the pressed letter
                if (main_richTextBox.SelectedText.Length > 0)
                {
                    undoRedoObj.Line = currentLine;
                    undoRedoObj.CharIndex = main_richTextBox.SelectionStart;
                    undoRedoObj.Action = "Replace";
                    undoRedoObj.DeletedTxt = main_richTextBox.SelectedText;
                    undoRedoObj.SelectionLength = 1;
                    undoList.Push(undoRedoObj);
                }




                // UndoTyping code -----------------------------------------------------------------
                UndoRedoModel undoRedoObjTyping = new UndoRedoModel();
                undoRedoObjTyping.CharIndex = main_richTextBox.SelectionStart;
                undoRedoObjTyping.SelectionLength= 1;


                if (e.KeyData == (Keys.Control | Keys.V)) // If Paste
                {
                    if (Clipboard.ContainsText(TextDataFormat.Text))
                    {
                        undoRedoObjTyping.SelectionLength = Clipboard.GetText(TextDataFormat.Text).Length;
                        undoRedoObjTyping.Action = "Paste";
                    }
                }

                undoList.Push(undoRedoObjTyping);

                //// UndoTyping code -----------------------------------------------------------------
                //UndoTypeModel undoTypeObj = new UndoTypeModel();
                //undoTypeObj.CharIndex = main_richTextBox.SelectionStart;

                //if (e.KeyData == (Keys.Control | Keys.V)) // If Paste
                //{
                //    if (Clipboard.ContainsText(TextDataFormat.Text))
                //    {
                //        undoTypeObj.Length = Clipboard.GetText(TextDataFormat.Text).Length;
                //        undoTypeObj.Action = "Paste";
                //    }
                //}

                //undoTypeList.Push(undoTypeObj);
            }
          
        }











        private void UndoTxt()
        {
            
            main_richTextBox.SelectionLength = 0; // Deselect the text

            if (undoList.Count > 0)
            {
                UndoRedoModel undoRedoObj = undoList.Pop(); // Get the UndoObj from the undoList
                             
                  main_richTextBox.Select(undoRedoObj.CharIndex, undoRedoObj.SelectionLength);
                  main_richTextBox.SelectedText = undoRedoObj.DeletedTxt;


                if (undoRedoObj.Action == "Del")
                {
                    main_richTextBox.Select(main_richTextBox.SelectionStart - 1, 0); // On undo type "Del button" move the carret -1 so it is in the correct position
                }
            }
            //else if(undoTypeList.Count > 0) // Undo after typing "Remove the last typed char on Undo when undo list is empty"
            //{
            //    UndoTypeModel undoType = undoTypeList.Pop(); // !!! Here add to Redo !! do it later

            //    //main_richTextBox.Selection
            //    main_richTextBox.Select(undoType.CharIndex, undoType.Length);
            //    main_richTextBox.SelectedText = "";
            //}

        }

 





        private void undo_button_Click(object sender, EventArgs e)
        {
            UndoTxt();
        }








        private void MainForm_Load(object sender, EventArgs e)
        {
            int ScreenW = Screen.PrimaryScreen.Bounds.Width;
            this.Size = new Size(360, 400);
            this.Location = new Point((ScreenW) - (this.Width), 0);
            this.Text = fileName;
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
                    newNoteForm.fileName = file;
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
            ToggleWordWrap();
        }

        private void ToggleWordWrap()
        {
            if (main_richTextBox.WordWrap == true)
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
         // Naming file code
            if(fileName == "")
            { 
                if (main_richTextBox.Text.Length > 0) // If not empty
                {
                  string txt = Regex.Replace(main_richTextBox.Text, " {2,}", " "); // Replace whitespaces if they are more than 2
                  txt = Regex.Replace(txt, @"\t|\n|\r", "");
               
                    if (txt.Length >= 10) // If it has at lerast 10 chars
                    {
                        fileName = path + $"Note - {txt.Substring(0, 10) + "#" + guiId}.rtf"; 
                    }
                    else // If it has less than 10 chars
                    {
                        fileName = path + $"Note - {txt.Substring(0, txt.Length) + "____" + guiId}.rtf"; 
                    }
                }
            }


            // Save Code
            Directory.CreateDirectory(path); // If directory does not exist create directory Example if it is first time this App is used ther is not Notes folder in C://Notes
            main_richTextBox.SaveFile(fileName, RichTextBoxStreamType.RichText);
            this.Text = fileName;
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
            string txt = Regex.Replace(main_richTextBox.Text, " {2,}", " "); // Replace whitespaces if they are more than 2
            txt = Regex.Replace(txt, @"\t|\n|\r", "");

            if (save && txt.Length > 0)
            {
               SaveTextToFile(); 
            }
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


        private void delete_note_button_Click(object sender, EventArgs e)
        {
            save = false;
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
           
            if(Application.OpenForms.Count > 1)
            {
                this.Close();
            }
            else
            {
                CloseAllForms();
            }
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