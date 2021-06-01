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

        public override void AddElement()
        {
           ImmobList.Add(new List<string>() { Name, Desc, distMov.ToString(), mainCost.ToString(), weight.ToString() });
            Console.WriteLine("Equipment added successfully");
        }

        public override void ShowDetails()
        {

            for (int i = 0; i < ImmobList.Count(); i++)
            {
                Console.WriteLine(ImmobList[i]);
            }

        }

        public override void NonMoved()
        {
            for (int i = 0; i < ImmobList.Count(); i++)
            {
                for (int j = 0; j < ImmobList[0].Count; j++)
                {
                    if (int.Parse(ImmobList[i][2]) == 0)
                    {
                        Console.WriteLine(ImmobList[i][0]);
                    }
                }
            }

        }

        public override void DeleteElement()
        {

            ImmobList.RemoveAt(0);

        }
        public override void ShowLessDetails()
        {
            Console.WriteLine("name of the equipment " + Name + " Discription of Equipment" + Desc);
        }
        public override void DeleteMobile()
        {

            for (int i = 0; i < MobList.Count(); i++)
            {
                ImmobList.RemoveAt(i);
            }
        }
        public override void DeleteAll()
        {
            DeleteMobile();
            DeleteImmobile();

        }
    }
}
