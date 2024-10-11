public class Comment
{
    private string _commentUserName;
    private string _commentText;

    public Comment(string commentUserName, string commentText)
    {
        _commentUserName = commentUserName;
        _commentText = commentText;
    }

    public string GetComment()
    {
        return _commentText;
    }

    public string GetUserName()
    {
        return _commentUserName;
    }
}