namespace ClassLibrary1
{
    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public Book SearchBook(string title)
        {
            return books.FirstOrDefault(i => i.GetTitle() == title);
        }

        public Book[] GetBooks() { return books.ToArray(); }
    }

}
