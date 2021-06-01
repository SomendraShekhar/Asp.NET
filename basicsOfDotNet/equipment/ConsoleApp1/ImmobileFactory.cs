using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ImmobileFactory:EquipmentFactory
    {
        public override Equipment Create(string name, string desc, int dist, int cost, int weighte, int wheels) => new Immobile(name, desc, dist, cost, weighte, wheels);

    }
}
