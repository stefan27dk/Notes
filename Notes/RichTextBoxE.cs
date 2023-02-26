using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RichTextBoxE : RichTextBox
{
    private const int WM_SETCURSOR = 0x20;

    protected override void WndProc(ref Message m)
    {
        if (m.Msg == WM_SETCURSOR)
        {
            if (SelectionType == RichTextBoxSelectionTypes.Object)
            {
                DefWndProc(ref m);
                return;
            }
        }

        base.WndProc(ref m);
    }
}
