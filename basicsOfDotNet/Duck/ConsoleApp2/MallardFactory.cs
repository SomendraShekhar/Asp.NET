using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MallardFactory: DuckFactory
    {
        public override Ducks Create(int weighte, int wing) => new Mallard(weighte, wing);
        
    }
}
