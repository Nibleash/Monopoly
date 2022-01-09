using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Game first_game = new Game();
            first_game.Create();
            first_game.Start();
            Console.ReadKey(true);
        }
    }
}
