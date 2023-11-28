public class Video
{
    protected string Title;
    protected string Author;
    protected int Length;

    public List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public int NumberOfComments()
    {
        return comments.Count;
    }

    public void AddComment(string Name, string Text)
    {
        comments.Add(new Comment(Name, Text));
    }

    public string GetString()
    {
        return $"Title: {Title}\nAuthor: {Author}\nLength: {Length}";
    }

    public void GetCommentString()
    {
        foreach (var comment in comments)
        {
            Console.WriteLine($"{comment.GetName()}, {comment.GetText()}");
        }        
    }

}