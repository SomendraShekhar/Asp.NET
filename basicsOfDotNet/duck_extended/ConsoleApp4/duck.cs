using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
   
        interface IDuck
        {
            void ShowDetails();
            
        }


        class RubberDuck : IDuck
        {
        public List<RubberDuck> RDuck = new List<RubberDuck>();
        public string Name;
        public int weight;
        public int wings;

        

        public RubberDuck()
        {
            weight = 0;
            wings = 0;
        }

            public  void ShowDetails()
            {
                Console.WriteLine(String.Join("",RDuck));
            }

            
        }
        class MallardDuck : IDuck
        {
        public string Name;
        public int weight;
        public int wings;
        public MallardDuck()
        {
            weight = 0;
            wings = 0;
        }
        public void ShowDetails()
            {
                Console.WriteLine(Name);
            }
        }
        class RedHead : IDuck
        {
        public string Name;
        public int weight;
        public int wings;
        public RedHead()
        {
            weight = 0;
            wings = 0;
        }
        public void ShowDetails()
            {
                Console.WriteLine(Name);
            }
        }
    }

