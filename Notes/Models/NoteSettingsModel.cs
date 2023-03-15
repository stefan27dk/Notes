using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes.Models
{
    public class NoteSettingsModel
    {  
       public Color NoteBackgroundColor { get; set; } = Color.FromArgb(255, 222, 115);
       public double Transparency { get; set;} = 1;
       public float ZoomFactor { get; set; } = 1;
       public Stack<UndoRedoModel> UndoRedoList { get; set; } = new Stack<UndoRedoModel>();
       public bool OnTop { get; set; } = false;
       public Size Size { get; set; } = new Size(360, 400);
       public int LocationX { get; set; } = 0;
       public int LocationY { get; set; } = 0;
    }
}
