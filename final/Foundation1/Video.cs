public class Video
{
    public string Title;
    public string Author;
    public int Length;

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

}