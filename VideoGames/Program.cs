using System;

namespace VideoGames
{
    // Interface 
    interface IVideoGames
    {
        public string Title { get; set; }
        public string Company { get; set; } 
        public int ReleaseYear { get; set; }

        void Play();
    }

    // Class Implementing interface 
    public class Game : IVideoGames
    {
        public string Title { get; set; }
        public string Company { get; set; }
        public int ReleaseYear { get; set; }

        public Game()
        {
            Title = string.Empty;
            Company = string.Empty;
            ReleaseYear = 0;
        }
        public Game(string title, string company,  int releaseYear)
        {
            Title = title;
            Company = company; 
            ReleaseYear = releaseYear;
        }

        // Implementing the method from the interface 
        public void Play()
        {
            Console.WriteLine($"You are now playing {Title}!");
        }
    }

    class Program
    {
        static void Main()
        {
            // Object created by using parameterized constructor
            Game myGame = new Game("Overwatch 2", "Blizzard Entertainment", 2022);

            Console.WriteLine($"Title: {myGame.Title}");
            Console.WriteLine($"Company: {myGame.Company}");
            Console.WriteLine($"Release Year: {myGame.ReleaseYear}");
            myGame.Play();

            Console.WriteLine(); // Line break for readibility 

            // Object created by using default contstructor 
            Game game = new Game();
            game.Title = "Destiny 2";
            game.Company = "Bungie";
            game.ReleaseYear = 2017;
            Console.WriteLine($"Title: {game.Title}");
            Console.WriteLine($"Company: {game.Company}");
            Console.WriteLine($"Release Year: {game.ReleaseYear}");
            game.Play();
        }
    }
}

