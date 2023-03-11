using Notes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

public class RichTextBoxE : RichTextBox
{
    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

    //this message is sent to the control when we scroll using the mouse
    private const int WM_MOUSEWHEEL = 0x20A;

    //and this one issues the control to perform scrolling
    private const int WM_VSCROLL = 0x115;



    private const int WM_SETCURSOR = 0x20;


    internal static ushort HIWORD(IntPtr dwValue)
    {
        return (ushort)((((long)dwValue) >> 0x10) & 0xffff);
    }

    internal static ushort HIWORD(uint dwValue)
    {
        return (ushort)(dwValue >> 0x10);
    }

    internal static int GET_WHEEL_DELTA_WPARAM(IntPtr wParam)
    {
        return (short)HIWORD(wParam);
    }

    internal static int GET_WHEEL_DELTA_WPARAM(uint wParam)
    {
        return (short)HIWORD(wParam);
    }



    protected override void WndProc(ref Message m)
    {
        
        if (m.Msg == WM_SETCURSOR) // Used for proper image resize without flickering and wrong cursor in the richtextbox
        {
            if (SelectionType == RichTextBoxSelectionTypes.Object)
            {
                DefWndProc(ref m);
                return;
            }
        }

        if (m.Msg == WM_MOUSEWHEEL) 
        {
           // Zoom text with CTRL + Mouse weel
            if(ModifierKeys.ToString() == "Control")
            {
                MainForm currentForm = (MainForm)this.FindForm();

                if (GET_WHEEL_DELTA_WPARAM(m.WParam) > 0)
                { 
                    if (this.ZoomFactor < 10)
                    { 
                        if (currentForm != null)
                        { 
                            currentForm.noteSettings.ZoomFactor = (float)(this.ZoomFactor + 0.3);
                        }
                        this.ZoomFactor = (float)(this.ZoomFactor + 0.3);
                    }
                }
                else
                {
                    if (this.ZoomFactor > 1)
                    {
                        if (currentForm != null)
                        {
                            currentForm.noteSettings.ZoomFactor = (float)(this.ZoomFactor - 0.3);
                        }

                        this.ZoomFactor = (float)(this.ZoomFactor - 0.3);
                    }
                }
                return;
            }


            // Removes smooth scrolling ...............................................
            int scrollLines = SystemInformation.MouseWheelScrollLines;
            for (int i = 0; i < scrollLines; i++)
            {
                if ((int)m.WParam > 0) // when wParam is greater than 0
                    SendMessage(this.Handle, WM_VSCROLL, (IntPtr)0, IntPtr.Zero); // scroll up 
                else
                    SendMessage(this.Handle, WM_VSCROLL, (IntPtr)1, IntPtr.Zero); // else scroll down
            }
            return;
        }
        base.WndProc(ref m);
    }
}
