using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fine_Arts.Models
{
    public class Student
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public byte age { get; set; }
        public Login IDDPAss { get; set; }
        public Event[] Events { get; set; }
        public Painting Painting { get; set; }

    }
}