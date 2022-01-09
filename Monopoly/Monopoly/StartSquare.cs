using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class StartSquare : ISquare
    {
        public SquareType SquareType => SquareType.StartSquare;
        public int Position => this.Position;

        public void PrintSquare(bool is_in_jail)
        {
            Console.WriteLine("\n* * * * * * * * * *\nRound and round - Start Square !\n* * * * * * * * * *\n");
        }

        public void Action(Player current) { }
    }
}
