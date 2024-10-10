public class Video
{
    private string _videoTitle;
    private string _videoAuthor;
    private int _videoLength;
    private List<Comment> _comments;

    public Video(List<Comment> comment)
    {
        _comments = comment;
    }

    public int GetComments()
    {
        return _comments.Count;
    }
}