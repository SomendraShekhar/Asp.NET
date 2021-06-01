using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public abstract class DuckFactory
    {
        public abstract Ducks Create(int weighte, int wing);
    }
}
