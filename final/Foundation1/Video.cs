using System.Text;

public class Video
{
    private string Title;
    private string Author;
    private int Length;

    public List<Comment> comments = new List<Comment>();

    // SMT you could create the List<Comment> outside of this class and pass the List<Comment> into the constructor.
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

    // SMT this works too
    public void AddComment(string Name, string Text)
    {
        comments.Add(new Comment(Name, Text));
    }

    public string GetString()
    {
        return $"Title: {Title}\nAuthor: {Author}\nLength: {Length}";
    }

    public string GetCommentString()
    {
        // SMT nice use of StringBuilder
        StringBuilder sb = new StringBuilder();

        foreach (var comment in comments)
        {
            sb.AppendLine($"{comment.ToStringComment()}");
        }

        return sb.ToString();
    }
}