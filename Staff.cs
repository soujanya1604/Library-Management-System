using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{

        // Derived class: Staff
        public class Staff : Person
        {
            public string Position { get; set; }
            public string Department { get; set; }

            public Staff(string name, string email, string id, string position, string department)
                : base(name, email, id)
            {
                Position = position;
                Department = department;
            }
        }
}
