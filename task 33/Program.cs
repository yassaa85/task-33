namespace task_33
{
    class Book
    {
        string title;
        string author;
        string isbn;
        bool availability;

        public Book(string title, string author, string isbn, bool availability)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.availability = availability;
        }
    }
    class Library
    {
        List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }



    }





    internal class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book("sport", "ayad", "131245", true);
            Library library = new Library();

        }
    }
}