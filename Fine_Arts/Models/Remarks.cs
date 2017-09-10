using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fine_Arts.Models
{
    public class Remarks
    {
        public int ID { get; set; }
        public string Remrks { get; set; }
        public Staff [] StaffRemarksOnPaintings { get; set; }
    }
}
