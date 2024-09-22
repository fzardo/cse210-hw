using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        int attempts = 0;

        // We could also use a do-while loop here...
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
                attempts++;
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
                attempts++;
            }
            else
            {
                Console.WriteLine($"You guessed it after {attempts} attempts.");
            }
        }                    
    }
}