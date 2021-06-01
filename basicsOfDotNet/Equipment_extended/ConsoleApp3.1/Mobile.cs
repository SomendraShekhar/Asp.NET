using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Mobile : Equipment
    {

        private int NoOfWheels;
       
        
        public Mobile(string name, string desc, int dist, int cost, int weighte, int wheels)
        {
            Name = name;
            Desc = desc;
            distMov = dist;
            mainCost = cost;
            NoOfWheels = wheels;
            
        }
        public override void MoveBy()
        {

            distMov = NoOfWheels * distMov;
            Console.WriteLine(Name + " " + distMov + " " + Desc + "Maintainenece Cost " + distMov);
        }

        public override void AddElement()
        {
            MobList.Add(new List<string>() { Name, Desc, distMov.ToString(), mainCost.ToString(),NoOfWheels.ToString() });
            Console.WriteLine("Equipment added successfully");
        }

        public override void ShowDetails()
        {
            for (int i = 0; i < MobList.Count(); i++)
            {
                Console.WriteLine(MobList[i]);
            }
        }
        public override void NonMoved()
        {
            for (int i = 0; i < MobList.Count(); i++)
            {
                for (int j = 0; j < MobList[0].Count; j++)
                {
                    if (int.Parse(MobList[i][2]) == 0)
                    {
                        Console.WriteLine(MobList[i][0]);
                    }
                }
            }   
        }

        public override void DeleteElement() {

            MobList.RemoveAt(0);

        }
        public override void ShowLessDetails() {
            Console.WriteLine("name of the equipment " + Name + " Discription of Equipment" + Desc);
        }
        public override void DeleteMobile()
        {

            for (int i = 0; i < MobList.Count(); i++)
            {
                MobList.RemoveAt(i);
            }
         }
        public override void DeleteAll() {
            DeleteMobile();
            DeleteImmobile();

        }
    }
}
