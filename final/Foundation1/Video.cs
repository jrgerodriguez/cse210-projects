using System.Text;

public class Video
{
    private string Title;
    private string Author;
    private int Length;

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

    public string GetCommentString()
    {
        StringBuilder sb = new StringBuilder();

        foreach (var comment in comments)
        {
            sb.AppendLine($"{comment.GetName()}, {comment.GetText()}");
        }

        return sb.ToString();
    }

}