using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Mobile : Equipment
    {
        
        private readonly int NoOfWheels;

        public Mobile(string name, string desc, int dist, int cost,int weighte, int wheels)
        {
            Name = name;
            Desc = desc;
            distMov = dist;
            mainCost = cost;
            NoOfWheels = wheels;


        }

         public override void MoveBy()
        {
            Console.WriteLine (Name + " " + distMov + " " + Desc + "Maintainenece Cost " + NoOfWheels * distMov);
           
        }
    }
}
