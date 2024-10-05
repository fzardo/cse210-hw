public class ScriptureLibrary
{
    private List<Scripture> _scriptures;

    // Constructor to initialize the scripture library with predefined scriptures
    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>
        {
            new Scripture(
                new Reference("1 Nephi", 3, 7),
                new List<string>
                {
                    "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."
                }
            ),
            new Scripture(
                new Reference("2 Nephi", 9, 28, 29),
                new List<string>
                {
                    "O that cunning plan of the evil one! O the vainness, and the frailties, and the foolishness of men! When they are learned they think they are wise, and they hearken not unto the counsel of God, for they set it aside, supposing they know of themselves, wherefore, their wisdom is foolishness and it profiteth them not. And they shall perish.",
                    "But to be learned is good if they hearken unto the counsels of God."
                }
            ),
            new Scripture(
                new Reference("Moroni", 10, 3, 5),
                new List<string>
                {
                    "Behold, I would exhort you that when ye shall read these things, if it be wisdom in God that ye should read them, that ye would remember how merciful the Lord hath been unto the children of men, from the creation of Adam even down until the time that ye shall receive these things, and ponder it in your hearts.",
                    "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.",
                    "And by the power of the Holy Ghost ye may know the truth of all things."
                }
            )
        };
    }

    // Method to get a random scripture
    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}
