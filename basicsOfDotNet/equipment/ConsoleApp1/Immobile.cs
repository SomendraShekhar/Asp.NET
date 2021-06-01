using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Immobile : Equipment
    {
        private readonly int weight;
        

        public Immobile(string name, string desc, int dist, int cost, int weighte,int wheels)
        {
            Name = name;
            Desc = desc;
            distMov = dist;
            mainCost = cost;
            weight = weighte;

        }
        public override void MoveBy()
        {
           Console.WriteLine( Name + " " + distMov + " " + Desc +"Miantainence Cost " + weight * distMov);
            
        }
    }
}
