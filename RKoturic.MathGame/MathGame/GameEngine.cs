

namespace MathGame
{
    internal class GameEngine
    {
     
        internal void additionGame()
        {
            var score = 0;
            int num1, num2;
            for (int i = 0; i < 5; i++)
            {
                Random rnd = new Random();
                num1 = rnd.Next(1, 9);
                num2 = rnd.Next(1, 9);


                Console.WriteLine($"{num1} + {num2} equals?");
                int result;
                Console.WriteLine("Enter a number:");

                while (!int.TryParse(Console.ReadLine(), out result))
                {
                    Console.WriteLine("Invalid input. Please try again and enter a number:");
                }

                if (result == num1 + num2)
                {
                    score++;
                    Console.WriteLine("Congratulations, that is correct answer!");
                    //Console.ReadKey(true);//Zbog true se ne ukucava tipka u consolu
                }
                else
                {
                    Console.WriteLine("Your answer is not correct!");
                }
                
                if (i == 4)
                {
                    Helpers.AddToGames("Addition Game", score);
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to return to the main menu");
                    Console.ReadLine();
                }
             
            }

        }

        internal void subtractionGame()
        {
            var score = 0;
            for (int i = 0; i < 5; i++)
            {
                Random rnd = new Random();
                int num1 = rnd.Next(1, 11);
                int num2 = rnd.Next(1, 11);

                Console.WriteLine($"{num1} - {num2} equals?");
                int result;
                Console.WriteLine("Enter a number:");

                while (!int.TryParse(Console.ReadLine(), out result))
                {
                    Console.WriteLine("Invalid input. Please try again and enter a number:");
                }

                if (result == num1 - num2)
                {
                    score++;
                    Console.WriteLine("Congratulations, that is correct answer!");

                }
                else
                {
                    Console.WriteLine("Your answer is not correct!");

                }
                if (i == 4)
                {
                    Helpers.AddToGames("Subtraction Game", score);
                    Console.WriteLine($"Game over. Your final score is {score}");
                    Console.ReadLine ();
                }
            }

        }

        internal void multiplicationGame()
        {
            var score = 0;
            for (int i = 0; i < 5; i++)
            {
                {
                    Random rnd = new Random();
                    int num1 = rnd.Next(1, 11);
                    int num2 = rnd.Next(1, 11);

                    Console.WriteLine($"{num1} * {num2} equals?");
                    int result;
                    Console.WriteLine("Enter a number:");

                    while (!int.TryParse(Console.ReadLine(), out result))
                    {
                        Console.WriteLine("Invalid input. Please try again and enter a number:");
                    }

                    if (result == num1 * num2)
                    {
                        score++;
                        Console.WriteLine("Congratulations, that is correct answer! ");

                    }
                    else
                    {
                        Console.WriteLine("Your answer is not correct!");

                    }
                }
                if (i == 4)
                {
                    Helpers.AddToGames("Multiplication Game", score);
                    Console.WriteLine($"Game over. Your final score is {score}");
                    Console.ReadLine();
                }
            }
        }

        internal void divisionGame()
        {
            var score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("DIVISION");
                Random rnd = new Random();
                int num1, num2;
                do
                {
                    num1 = rnd.Next(1, 11);
                    num2 = rnd.Next(1, 11);

                }
                while (num1 % num2 != 0);
                Console.WriteLine($"{num1} / {num2} equals?");
                int result;
                Console.WriteLine("Enter a number:");

                while (!int.TryParse(Console.ReadLine(), out result))
                {
                    Console.WriteLine("Invalid input. Please try again and enter a number:");
                }

                if (result == num1 / num2)
                {
                    score++;
                    Console.WriteLine("Congratulations, that is correct answer!");

                }
                else
                {
                    Console.WriteLine("Your answer is not correct!");

                }
                if (i == 4) {
                    Helpers.AddToGames("Division Game", score);
                    Console.WriteLine($"Game over. Your final score is {score}");
                    Console.ReadLine();
                }
            }
        }
    }
}
