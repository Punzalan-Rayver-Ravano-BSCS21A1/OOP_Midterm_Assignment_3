namespace ClassLibrary1
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string ISBN { get; }
        public Book(string Title, string Author, string ISBN)
        {
            this.Title = Title;
            this.Author = Author;
            this.ISBN = ISBN;
        }

        public string GetTitle()
        {
            return this.Title;
        }

    }

}
