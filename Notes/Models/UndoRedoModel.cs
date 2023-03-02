using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Models
{
    internal class UndoRedoModel
    {
        public int Line { get; set; }
        public int CharIndex { get; set; }
        public string Action { get; set; } = "";
        public string DeletedTxt { get; set; } = ""; 
    }
}
