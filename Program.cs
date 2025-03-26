namespace Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Adding books
            library.Books.Add(new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4));
            library.Books.Add(new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3));
            library.Books.Add(new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6));

            // Adding patrons
            library.Person.Add(new student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", "2026"));
            library.Person.Add(new student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", "2025"));
            library.Person.Add(new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services"));

            library.DisplayBooks();
            library.DisplayPatrons();

            Console.WriteLine("Borrowing Books...");
            library.Books[1].BorrowBook("Sandeep", library.Books[1].Title); 
            library.Books[2].BorrowBook("Akhil", library.Books[2].Title); 

            Console.WriteLine("Books after borrowing:");
            library.DisplayBooks();
        }
    }
}
