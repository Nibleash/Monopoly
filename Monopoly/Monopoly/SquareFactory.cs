using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class SquareFactory
    {
        public ISquare Create(SquareType squareType)
        {
            switch (squareType)
            {
                case SquareType.JailSquare:
                    return new JailSquare();
                case SquareType.LuckSquare:
                    return new LuckSquare();
                case SquareType.CommunitySquare:
                    return new CommunitySquare();
                case SquareType.StartSquare:
                    return new StartSquare();
                case SquareType.NormalSquare:
                    return new NormalSquare();
                case SquareType.GoToJailSquare:
                    return new GoToJailSquare();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
