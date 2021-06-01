using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Duckling
    {
        private Dictionary<DuckTyps, DuckFactory> _Fact;
        public Duckling()
        {
            _Fact = new Dictionary<DuckTyps, DuckFactory>{

                {DuckTypes.RedHead, new RedHeadFactory() },
                {DuckTyps.Mallard,new MallardFactory() },
                {DuckTyps.Rubber, new RubberFactory() }
            };
        }

        public 
            
    }
}
