using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fine_Arts.Models
{
    public class Role
    {
        public int ID { get; set; }
        public String Roles { get; set; }
        public Staff StaffMembers { get; set; }
    }
}