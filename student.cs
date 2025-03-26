using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Student : Person
    {
        public string major { get; set; }
        public string graduation_year { get; set; }

        public Student(string name, string email, string id, string major, string graduation_year) : base(name, email, id)
        {
            this.major = major;
            this.graduation_year = graduation_year;
        }
        public void display()
        {

            Console.WriteLine("Major : ", major);
            Console.WriteLine("Graduation Year : ", graduation_year);
        }

    }
}
