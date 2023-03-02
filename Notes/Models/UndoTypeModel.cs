using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Models
{
    internal class UndoTypeModel
    {
       public  int CharIndex { get; set; }
       public int Length { get; set; } = 1;
       public string Action { get; set; } = "";
    }
}
