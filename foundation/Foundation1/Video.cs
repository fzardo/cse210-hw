public class Video
{
    private string _videoTitle;
    private string _videoAuthor;
    private int _videoLength;
    private List<Comment> _comments;

    public Video(string title, string author, int length, List<Comment> comments)
    {
        _videoTitle = title;
        _videoAuthor = author;
        _videoLength = length;
        _comments = comments;
    }

    public int GetNumberOfComments()
    {
        return _comments.Count();
    }

    public List<Comment> GetListOfComments()
    {
        return _comments;
    }

    public string GetTitle()
    {
        return _videoTitle;
    }

    public string GetAuthor()
    {
        return _videoAuthor;
    }

    public int GetVideoLength()
    {
        return _videoLength;
    }
}