﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fine_Arts.Models
{
    public class Painting
    {
        public int ID { get; set; }
        public string paintings { get; set; }
        public Student [] Students { get; set; }

        public Event [] Events { get; set; }
        public Remarks [] staffRemarksOnPaintings { get; set; }
    }
}
