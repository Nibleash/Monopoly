using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public abstract class PlayerAggregate
    {
        public abstract Iterator CreateIterator();
    }
}
