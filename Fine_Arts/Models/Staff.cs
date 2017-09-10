using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fine_Arts.Models
{
   public class Staff
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String PASS { get; set; }
        public Role Roles { get; set; }
        
    }
}
