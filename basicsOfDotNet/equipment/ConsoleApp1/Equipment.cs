using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     public abstract class Equipment
    {
        public string Name;
        public string Desc;
        public int distMov = 0;
        public int mainCost = 0;

        public virtual void MoveBy() { }
        
        
        
    }
    
   
}
