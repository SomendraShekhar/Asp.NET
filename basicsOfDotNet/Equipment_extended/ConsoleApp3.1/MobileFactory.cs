using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MobileFactory : EquipmentFactory
    {

        public List<Mobile> he = new List<Mobile>();



        public override Equipment Create(string name, string desc, int dist, int cost, int weighte, int wheels) => new Mobile(name, desc, dist, cost, weighte, wheels);

    }

 

}
