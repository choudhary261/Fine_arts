using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fine_Arts.Models
{
     public class Event
    {
        public int ID { get; set; }
        public String Events { get; set; }
        public Student [] Students { get; set; }
        public Painting Paintings { get; set; }
        public Remarks [] StaffRemarksOnPaintings { get; set; }
    }
}
