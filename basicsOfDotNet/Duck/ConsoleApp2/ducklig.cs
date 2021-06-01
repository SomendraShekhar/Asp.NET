using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ducklig
    {
        private Dictionary<DuckTyps, DuckFactory> _Fact;
        public ducklig()
        {
            _Fact = new Dictionary<DuckTyps, DuckFactory>{

                {DuckTyps.RedHead, new RedHeadFactory() },
                {DuckTyps.Mallard,new MallardFactory() },
                {DuckTyps.Rubber, new RubberFactory() }
            };
        }

        public Ducks ExecuteCreation(DuckTyps ducktyps , int weighte, int wing) => _Fact[ducktyps].Create(weighte, wing);

    }
}
