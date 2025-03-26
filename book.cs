namespace Library_Management_System
{
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
            public int AvailableCopies { get; set; }

            public Book(string title, string author, string isbn, int availableCopies)
            {
                Title = title;
                Author = author;
                ISBN = isbn;
                AvailableCopies = availableCopies;
            }

            public bool BorrowBook(string borrowerName, string bookTitle)
            {
                if (AvailableCopies > 0)
                {
                    AvailableCopies--;
                    Console.WriteLine($"{borrowerName} borrowed '{bookTitle}'");
                    return true;
                }
                return false;
            }

            public void ReturnBook()
            {
                AvailableCopies++;
            }
        }

        // Library class
        public class Library
        {
            public List<Book> Books { get; set; } = new List<Book>();
            public List<Person> Person { get; set; } = new List<Person>();

            public void DisplayBooks()
            {
                Console.WriteLine("Books in Library:");
                foreach (var book in Books)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available Copies: {book.AvailableCopies}");
                }
                Console.WriteLine();
            }

            public void DisplayPatrons()
            {
                Console.WriteLine("Patrons in Library:");
                foreach (var patron in Person)
                {
                    Console.WriteLine($"Name: {patron.Name}, ID: {patron.ID}");
                }
                Console.WriteLine();
            }
        }

}

