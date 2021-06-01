using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Mallard : Ducks
    {
        public int weight;
        public int wings;
        public Mallard(int weighte,int wing)
        {
            weight = weighte;
            wings = wing;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Mallard ducks fly fast and quack loud ,weigh" + weight + " kg, and have" + wings + " wings");
        }
    }
}
