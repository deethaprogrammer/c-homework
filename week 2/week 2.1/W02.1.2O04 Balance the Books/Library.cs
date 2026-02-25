public class Library
{
    public List<Book> Books = new();
    public int MaxBooks;

    public Library(int MaxBooks)
    {
        this.MaxBooks = MaxBooks;
    }

    public bool AddBook(int id, string title)
    {
        if (Books.Count >= MaxBooks) {return false;}
        Books.Add(new Book(id, title));
        return true;
    }

    public Book FindBookById(int id)
    {
        foreach (Book book in Books)
        {
            if (book.Id == id) {return book;}
        }
        return null;
    }

    public void EditBookTitle(int id, string newTitle)
    {
        Book book = FindBookById(id);
        if (book != null)
        {
            book.Title = newTitle;
        }
    }

    public void RemoveBookById(int id)
    {
        Books.RemoveAll(book => book.Id == id);
    }
}