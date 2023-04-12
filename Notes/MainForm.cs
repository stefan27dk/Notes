using Microsoft.Win32;
using Notes.Models;
using Notes.Models.Logic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Security.Policy;
using System.Text.Json;
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
            //main_richTextBox.MouseWheel += new MouseEventHandler(main_richTextBox_Mouse_Weel);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.OnPrintPage); 
        }

       
        Stack<UndoRedoModel> undoList = new Stack<UndoRedoModel>();
        Stack<UndoRedoModel> redoList = new Stack<UndoRedoModel>();
      

        string path = $"C:\\Notes\\";
        string fileName = "";
        bool save = true;
        MainForm newForm;
        public NoteSettingsModel noteSettings = new NoteSettingsModel();

        // Main Form Load -----------------------------------------------------------------------------------------------------------------
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            if (noteSettings.LocationX == 0 && noteSettings.LocationY == 0)
            {
                int ScreenW = Screen.PrimaryScreen.Bounds.Width;
                this.Location = new Point((ScreenW) - (this.Width), 0); // Default location for the note if location is empty = 0

                // Add the loaction to the settings object
                noteSettings.LocationX = this.Location.X;
                noteSettings.LocationY = this.Location.Y;
            }
            else
            {
              ApplySettings();
            }

            //this.Size = new Size(360, 400); 
            this.Text = fileName;
            main_richTextBox.AppendText(Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine);
            Drag_Drop_Hook_Eventhandlers();
            ToggleStarupButtonIcon();
        }

        //private void main_richTextBox_Mouse_Weel(object sender, MouseEventArgs e)
        //{
        //    //main_richTextBox.Text = "sdass";
        //}

        private void ApplySettings()
        {
            main_richTextBox.BackColor = noteSettings.NoteBackgroundColor;
            this.Opacity = noteSettings.Transparency;
            main_richTextBox.ZoomFactor = noteSettings.ZoomFactor;
            this.TopMost = noteSettings.OnTop;
            this.Size= noteSettings.Size;
            this.Location = new Point(noteSettings.LocationX, noteSettings.LocationY);
        }

        private void Drag_Drop_Hook_Eventhandlers()
        {
            main_richTextBox.DragEnter += main_richTextBox_DragEnter;
            main_richTextBox.DragDrop += main_richTextBox_DragDrop;

            //main_richTextBox.AllowDrop = true;
            //main_richTextBox.EnableAutoDragDrop = true;
        }

        private void main_richTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void main_richTextBox_DragDrop(object sender, DragEventArgs e)
        {

            Invoke(new Action(() =>
            {
                string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop, false);

                if (paths != null)
                {
                    RichTextBox rt_box = new RichTextBox();


                    for (int i = 0; i < paths.Length; i++)
                    {
                        if (paths.Length > 1)
                        {
                            if (paths[i].Substring(paths[i].Length - 4) == ".rtf")
                            {
                                rt_box.LoadFile(paths[i]);
                                this.main_richTextBox.Rtf = this.main_richTextBox.Rtf.Substring(0, this.main_richTextBox.Rtf.Length - 3) + rt_box.Rtf.Substring(1, rt_box.Rtf.Length - 1); // Merging rtf file becuase if thi is not doen images are not showed when loaded.

                                e.Effect = DragDropEffects.None; // With this the paste won't be doubled
                            }
                            else if (paths[i].Substring(paths[i].Length - 4) == ".txt")
                            {
                                string text = System.IO.File.ReadAllText(paths[i]);
                                main_richTextBox.AppendText(text);
                            }
                        }
                        else if (paths[i].Substring(paths[i].Length - 4) == ".rtf")
                        {
                            this.main_richTextBox.LoadFile(paths[i]);
                            fileName = paths[i];
                            this.Text = paths[i];
                            e.Effect = DragDropEffects.None; // With this the paste won't be doubled
                        }
                        else if (paths[i].Substring(paths[i].Length - 4) == ".txt") // Load Txt
                        {
                            string text = System.IO.File.ReadAllText(paths[i]);
                            main_richTextBox.AppendText(text);
                            e.Effect = DragDropEffects.None; // With this the paste won't be doubled
                        }
                    }
                }
            })); 
        }



















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
                if (main_richTextBox.SelectionLength == 0 && main_richTextBox.Text.Length > 0) // If there is no selection
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
            else if (e.Control && e.Alt)
            {
                e.SuppressKeyPress = true;
                main_richTextBox.ScrollToCaret();
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
            else if (e.KeyData == (Keys.Control | Keys.Y))
            {
                e.SuppressKeyPress = true;
                RedoTxt();
            }
            else if (e.KeyData == (Keys.Control | Keys.X))
            {
                if (main_richTextBox.SelectionLength == 0)
                {
                    e.SuppressKeyPress = true;
                    DeleteCurrentLine();
                }
            }
            else if(!char.IsControl(Convert.ToChar(e.KeyCode)) || e.KeyData == (Keys.Control | Keys.V))
            {
                // Undo add to list if there is selected text and any key letter or number is pressed and has replaced the text with the pressed letter
                if (main_richTextBox.SelectedText.Length > 0)
                {
                    undoRedoObj.Line = currentLine;
                    undoRedoObj.CharIndex = main_richTextBox.SelectionStart;
                    undoRedoObj.Action = "Replace";
                    undoRedoObj.DeletedTxt = main_richTextBox.SelectedText;
                    undoRedoObj.SelectionLength = 0;
                    undoList.Push(undoRedoObj);
                }




                // UndoTyping code -----------------------------------------------------------------
                UndoRedoModel undoRedoObjTyping = new UndoRedoModel();
                undoRedoObjTyping.CharIndex = main_richTextBox.SelectionStart;
                undoRedoObjTyping.SelectionLength = 1;
                undoRedoObjTyping.DeletedTxt = Convert.ToChar(e.KeyCode).ToString();
                undoRedoObjTyping.Type = "UndoType";



                if (e.KeyData == (Keys.Control | Keys.V)) // If Paste
                {
                    if (Clipboard.ContainsText(TextDataFormat.Text))
                    {
                        string clipBoradTxt = Clipboard.GetText(TextDataFormat.Text);
                        undoRedoObjTyping.SelectionLength = clipBoradTxt.Length;
                        undoRedoObjTyping.DeletedTxt = clipBoradTxt;
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

                //// For Redo
                //if (undoRedoObj.Action != "Replace") // For the Redo if there was pasted txt and wa replace - in order not to loose the pasted text when redo is used
                //{
                //    redoList.Push(undoRedoObj); // Add to Redo List
                //}
                redoList.Push(undoRedoObj); // Add to Redo List

                main_richTextBox.Select(undoRedoObj.CharIndex, undoRedoObj.SelectionLength);


                if (undoRedoObj.Type == "UndoType")
                {
                  main_richTextBox.SelectedText = "";
                }
                else
                {
                    main_richTextBox.SelectedText = undoRedoObj.DeletedTxt;
                }




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

 




        private void  RedoTxt()
        {
            if(redoList.Count > 0)
            { 
                UndoRedoModel undoRedoObj = redoList.Pop();

                //undoList.Push(undoRedoObj);


                if (undoRedoObj.Action == "Replace")
                {
                    UndoRedoModel undoObjRewrite = new UndoRedoModel();
                    undoObjRewrite.Action = undoRedoObj.Action;
                    undoObjRewrite.DeletedTxt = undoRedoObj.DeletedTxt; 
                    undoObjRewrite.Line = undoRedoObj.Line;
                    undoObjRewrite.CharIndex = undoRedoObj.CharIndex;
                    undoObjRewrite.Type = undoRedoObj.Type;


                    // Replace the "aaa" length with the "45 length"
                    int replacedTxtLength = undoRedoObj.DeletedTxt.Length;
                    if(redoList.Count > 0)
                    {
                        undoRedoObj = redoList.Pop();
                    }
                    //undoList.Push(undoRedoObj);
                    undoRedoObj.SelectionLength = replacedTxtLength+1;
                     
                    undoObjRewrite.SelectionLength = undoRedoObj.DeletedTxt.Length;
                    undoList.Push(undoObjRewrite);
                }
                else if(undoRedoObj.Action == "Enter")
                {
                    undoList.Push(undoRedoObj); // Push the unmodified object to undo
                    undoRedoObj.DeletedTxt = Environment.NewLine;
                    undoRedoObj.SelectionLength = 1;
                }
                else
                {
                    undoList.Push(undoRedoObj);
                }
                // Take the 45 and replace its length with the "aaa"

 
                main_richTextBox.Select(undoRedoObj.CharIndex, undoRedoObj.SelectionLength-1);



                //if (undoRedoObj.Action == "Paste")
                //{
                //    main_richTextBox.SelectedText = "";
                //}
                if (undoRedoObj.Action == "Del")
                {
                    main_richTextBox.Select(main_richTextBox.SelectionStart - 1, 0); // On undo type "Del button" move the carret -1 so it is in the correct position
                }
                main_richTextBox.SelectedText = undoRedoObj.DeletedTxt;




                
            }
        }



        private void undo_button_Click(object sender, EventArgs e)
        {
            UndoTxt();
        }









        private void ReadAllNotes()
        {
            string[] filesArray = Directory.GetFiles(path);

            foreach (var file in filesArray)
            {
                if(file.Substring(file.Length-4) == ".rtf")
                {
                    new Thread(() =>
                    {
                        var newNoteForm = new MainForm();
                        newNoteForm.main_richTextBox.LoadFile(file);
                        newNoteForm.fileName = file;
                        newNoteForm.ReadSettingsFile(file);
                        //newNoteForm.ApplySettings();
                        //newNoteForm.applySettingsState = true;
                        newNoteForm.Show();
                        Application.Run();
                    }).Start();
                }
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
            main_richTextBox.ZoomFactor = 1 + (float)(zoom_richtextbox_trackBar.Value * 0.05);
            noteSettings.ZoomFactor = 1 + (float)(zoom_richtextbox_trackBar.Value * 0.05);
        }




        private void form_opacity_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = form_opacity_trackBar.Value * 0.01;  // Adjust Form Opacity
            noteSettings.Transparency = form_opacity_trackBar.Value * 0.01; // Add to settings object // Later on is saved together with the file
        }






        private void onTop_button_Click(object sender, EventArgs e)
        {
            if (this.TopMost == false)
            {
                this.TopMost = true;
                noteSettings.OnTop = true;
            }
            else
            {
                this.TopMost = false;
                noteSettings.OnTop = false;
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

        private void CreateFilename()
        {
            string guiId = System.Guid.NewGuid().ToString();
            // Naming file code - Generate Name
            if (fileName == "")
            {
                if (main_richTextBox.Text.Length > 0) // If not empty
                {
                    string txt = Regex.Replace(main_richTextBox.Text, " {2,}", " "); // Replace whitespaces if they are more than 2
                    txt = Regex.Replace(txt, @"\t|\n|\r", "");

                    if (txt.Length >= 10) // If it has at least 10 chars
                    {
                        fileName = path + $"Note - {txt.Substring(0, 10) + "#" + guiId}.rtf";
                    }
                    else // If it has less than 10 chars
                    {
                        fileName = path + $"Note - {txt.Substring(0, txt.Length) + "____" + guiId}.rtf";
                    }
                }
            }

        }

        private void SaveTextToFile()
        {
            CreateFilename();
            // Save Code
            Directory.CreateDirectory(path); // If directory does not exist create directory Example if it is first time this App is used ther is not Notes folder in C://Notes
            main_richTextBox.SaveFile(fileName, RichTextBoxStreamType.RichText);
            this.Text = fileName;

        }



        private void CreateSettingsFile()
        {
            // Add Window location to the Settings Model
            noteSettings.LocationX = this.Location.X;
            noteSettings.LocationY = this.Location.Y;

            //Directory.CreateDirectory(path); // If directory does not exist create directory Example if it is first time this App is used ther is not Notes folder in C://Notes

            //string json = JsonSerializer.Serialize(noteSettings);
            //File.WriteAllText(fileName.Substring(0, fileName.Length-3) + "json", json);

            if (fileName.Length > 0)
            {
                var options = new JsonSerializerOptions()
                {
                    Converters = { new ColorJsonConverter() }
                };

                string json = JsonSerializer.Serialize(noteSettings, options);
                File.WriteAllText(fileName.Substring(0, fileName.Length - 3) + "json", json);
                //await using FileStream createStream = File.Create(fileName.Substring(0, fileName.Length - 3) + "json");
                //await JsonSerializer.SerializeAsync(createStream, noteSettings); 
            }
        }



        private void ReadSettingsFile(string fileName)
        {
            //string json = JsonSerializer.Serialize(noteSettings);
            //File.WriteAllText(fileName.Substring(0, fileName.Length-3) + "json", json);

            string jsonFile = fileName.Substring(0, fileName.Length - 3) + "json";
            
            if (File.Exists(jsonFile))
            {

                var options = new JsonSerializerOptions()
                {
                    Converters = {new ColorJsonConverter()}
                };


                string jsonString = File.ReadAllText(jsonFile);
                NoteSettingsModel loadedSettings = JsonSerializer.Deserialize<NoteSettingsModel>(jsonString, options)!;
                 
                if (loadedSettings != null)
                {
                    noteSettings = loadedSettings;
                }
            }
        }




        private void save_button_Click(object sender, EventArgs e)
        {
            SaveTextToFile(); 
            CreateSettingsFile();
        }

     

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(save)
            { 
              CreateFileNameAndSave(); 
              CreateSettingsFile();
            }


            // Close all forms if last form is closing
            if (Application.OpenForms.Count == 1)
            {
                CloseAllForms();
            }
        }

        private void CreateFileNameAndSave()
        {
            string txt = Regex.Replace(main_richTextBox.Text, " {2,}", " "); // Replace whitespaces if they are more than 2
            txt = Regex.Replace(txt, @"\t|\n|\r", "");

            if (txt.Length > 0)
            {
                SaveTextToFile();
            }
        }


      




        private void start_on_startup_button_Click(object sender, EventArgs e)
        {
            // The path to the key where Windows looks for startup applications
            RegistryKey regKeyStartup = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            //bool runonStartup = true;


            if (regKeyStartup.GetValue("Notes") == null) // Check if there is a key already, if there is not create it
            {
                // Add the value in the registry so that the application runs at startup
                regKeyStartup.SetValue("Notes", Application.ExecutablePath);
                start_on_startup_button.BackgroundImage = global::Notes.Properties.Resources.start;
            }
            else // If there is key and the button is pressed than delete the key
            {
                // Remove the value from the registry so that the application doesn't start
                regKeyStartup.DeleteValue("Notes", false);
                start_on_startup_button.BackgroundImage = global::Notes.Properties.Resources.play_button_red;
            }

        }


        private void ToggleStarupButtonIcon()
        {
            RegistryKey regKeyStartup = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (regKeyStartup.GetValue("Notes") == null) // Check if there is a key already, if there is not create it
            {
                start_on_startup_button.BackgroundImage = global::Notes.Properties.Resources.play_button_red;
            }
            else // If there is key and the button is pressed than delete the key
            {
                start_on_startup_button.BackgroundImage = global::Notes.Properties.Resources.start;
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
                File.Delete(fileName.Substring(0, fileName.Length - 3) + "json");
            }

            if (Application.OpenForms.Count > 1)
            {
                this.Close();
            }
            else
            {
                CloseAllForms();
            }
        }

        private void main_richTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShowCharIndexAndLine();
            //int wordsCount = main_richTextBox.Text.Split(' ').Length;
            //words_count_label.Text = "Words:" + wordsCount.ToString();
             
        }


        private void ShowCharIndexAndLine()
        {
            int charIndex = main_richTextBox.GetFirstCharIndexOfCurrentLine();
            char_index_label.Text = "Char Index:" + charIndex;
            line_label.Text = "Line:" + main_richTextBox.GetLineFromCharIndex(charIndex).ToString();
        }

        private void main_richTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            ShowCharIndexAndLine();
        }

        private void main_richTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        { 
            Process.Start("explorer", e.LinkText);
        }

        private void copy_all_button_Click(object sender, EventArgs e)
        {
            int currentCaret = main_richTextBox.SelectionStart;
            main_richTextBox.SelectAll();
            Clipboard.SetText(main_richTextBox.SelectedText);
            main_richTextBox.DeselectAll();
            main_richTextBox.Focus();
            main_richTextBox.SelectionStart = currentCaret;
        }

        private void scroll_to_top_button_Click(object sender, EventArgs e)
        {
            main_richTextBox.SelectionStart = 0;
            main_richTextBox.ScrollToCaret();
            main_richTextBox.Focus();
        }

        private void scroll_to_bottom_button_Click(object sender, EventArgs e)
        {
            main_richTextBox.SelectionStart = main_richTextBox.Text.Length;
            main_richTextBox.ScrollToCaret();
            main_richTextBox.Focus();
        }

        private void today_button_Click(object sender, EventArgs e)
        {
            string today = DateTime.Now.ToString(" dd-MM-yyyy  HH:mm:ss");
            main_richTextBox.SelectedText = today;
            main_richTextBox.Focus();
        }

        private void to_do_button_Click(object sender, EventArgs e)
        {
            int currentCaret = main_richTextBox.SelectionStart;
            string toDoTxt = "\nTo Do:\n\n1.\n2.\n3.\n4.\n5.\n6.\n7.\n8.\n9.\n10.\n11.\n12.\n13.\n14.\n15.\n16.\n17.\n18.\n19.\n20.\n";
            main_richTextBox.SelectedText = toDoTxt;
            main_richTextBox.Focus();
            main_richTextBox.SelectionStart = currentCaret + 11;

        }

        private void main_richTextBox_TextChanged(object sender, EventArgs e)
        {
            MatchCollection wordCount = Regex.Matches(main_richTextBox.Text, @"[\W]+");
            words_count_label.Text = "Words:" +  wordCount.Count.ToString();

            //int wordsCount = main_richTextBox.Text.Split(' ').Length;
            //words_count_label.Text = "Words:" + wordsCount.ToString();
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
         











        // Print Richtextbox ---------------------------------------------------------------------------------------------
        private void print_button_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }







 

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            char[] param = { '\n' };

            if (printDialog1.PrinterSettings.PrintRange == PrintRange.Selection)
            {
                lines = main_richTextBox.SelectedText.Split(param);
            }
            else
            {
                lines = main_richTextBox.Text.Split(param);
            }

            int i = 0;
            char[] trimParam = { '\r' };
            foreach (string s in lines)
            {
                lines[i++] = s.TrimEnd(trimParam);
            }
        }

        private int linesPrinted;
        private string[] lines;

        private void OnPrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            Brush brush = new SolidBrush(main_richTextBox.ForeColor);

            while (linesPrinted < lines.Length)
            {
                e.Graphics.DrawString(lines[linesPrinted++],
                    main_richTextBox.Font, brush, x, y);
                y += 15;
                if (y >= e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            linesPrinted = 0;
            e.HasMorePages = false;
        }

        private void chgange_collor_button_Click(object sender, EventArgs e)
        {
            ColorDialog clrDialog = new ColorDialog();
            
            //Show the colour dialog and check that user clicked ok
            if (clrDialog.ShowDialog() == DialogResult.OK)
            { 
                noteSettings.NoteBackgroundColor = clrDialog.Color;
                main_richTextBox.BackColor = clrDialog.Color;
            } 
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            noteSettings.Size = this.Size;
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            if(menu_panel.Visible == false)
            {
                menu_panel.Visible = true;
                typer_holder_panel.Location = new Point(typer_holder_panel.Location.X, typer_holder_panel.Location.Y + menu_panel.Size.Height - 55);
            }
            else
            {
                menu_panel.Visible = false;
                typer_holder_panel.Location = new Point(typer_holder_panel.Location.X, typer_holder_panel.Location.Y - menu_panel.Size.Height + 55);
            }
        }
    }
}