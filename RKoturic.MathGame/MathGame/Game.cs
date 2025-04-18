using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal interface Game
    {
        string Name { get; }
        int Points { get; }
    }
}
