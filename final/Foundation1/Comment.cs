public class Comment
{
    private string Name;
    private string Text;

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }

    // SMT Replace these getters with a Tostring() that returns the formatted text representing the Comment
    public string ToStringComment()
    {
        return $"{Name}: {Text}";
    }
}