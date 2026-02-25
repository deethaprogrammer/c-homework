public class Book
{
    public int Id;
    public string Title;

    public Book(int Id, string Title)
    {
        this.Id = Id;
        this.Title = Title;
    }

    public string GetInfo()
    {
        return $"ID: {this.Id}, Title: {this.Title}";
    }
}