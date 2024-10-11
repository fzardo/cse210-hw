using System;

class Program
{
    static void Main(string[] args)
    {
        // Create comments for the videos
        List<Comment> comments1 = new List<Comment>
        {
            new Comment("Mick", "Delicious!"),
            new Comment("Joe", "I want to try it."),
            new Comment("Lina", "I didn't know those tips.")
        };

        List<Comment> comments2 = new List<Comment>
        {
            new Comment("Peter", "Very informative."),
            new Comment("Mary", "You make learning so easy!"),
            new Comment("Joseph", "Can't wait for the next one."),
            new Comment("Donald", "I have learned a lot!")
        };

        List<Comment> comments3 = new List<Comment>
        {
            new Comment("Louis", "It's fantastic!"),
            new Comment("Jonathan", "So creative!"),
            new Comment("Luna", "Loved the visuals.")
        };

        // Create videos and add comments to them
        List<Video> videos = new List<Video>
        {
            new Video("How to Cook Pasta", "ChefJohn", 325, comments1),
            new Video("Understanding C# Basics", "TechGuru", 534, comments2),
            new Video("Exploring the Universe", "AstroNerd", 898, comments3)
        };

        // Iterate through the list of videos and display the information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetVideoLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetListOfComments())
            {
                Console.WriteLine($"- {comment.GetUserName()}: {comment.GetComment()}");
            }
            Console.WriteLine();
        }
    }
}