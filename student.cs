namespace Library_Management_System
{
    public class student : Person
    {
        public string major {get; set;}
        public string graduation_year { get; set; }

        public student(string name,  string email,string id, string major, string graduation_year) : base(name, email,id)
        {
            this.major = major;
            this.graduation_year = graduation_year;
        }
    }
    
}
