using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Helpers
    {
        static List<string> games = new List<string>();

        internal static void GetGames()
        {
            Console.Clear();
            Console.WriteLine("Games History!");
            Console.WriteLine("------------------------------------------");
            foreach(var game in games)
            {
                Console.WriteLine(game);
            }
        }

        internal static void AddToGames(string name, int score)
        {
            games.Add($"{name} / Score:{score}");
        }
    }
}
