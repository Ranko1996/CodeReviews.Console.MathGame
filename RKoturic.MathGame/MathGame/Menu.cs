

namespace MathGame
{
    internal class Menu
    {
        internal void ShowMenu()
        {
            var gameEngine = new GameEngine();
            bool isGameOn = true;

            do
            {
                Console.WriteLine("Hello, What game do you want to play today?\nChoose from options below!");
                Console.WriteLine("V - View previous games \n" +
                    "A - Addition \n" +
                    "S - Subtraction \n" +
                    "M - Multiplication \n" +
                    "D - Division \n" +
                    "Q - Quit the program");
                Console.WriteLine("------------------------------------------");

                string game = Console.ReadLine();
                Console.WriteLine($"You choose {game}");


                switch (game.Trim().ToLower())
                {
                    case "v":
                        Helpers.GetGames();
                        break;
                    case "a":
                        gameEngine.additionGame();
                        break;
                    case "s":
                        gameEngine.subtractionGame();
                        break;
                    case "m":
                        gameEngine.multiplicationGame();
                        break;
                    case "d":
                        gameEngine.divisionGame();
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        Environment.Exit(1);
                        break;
                }
            } while (isGameOn);
           
          
        }

    }
    
}
