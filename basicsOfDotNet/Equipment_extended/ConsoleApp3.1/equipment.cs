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
        public List<List<string>> MobList = new List<List<string>>();
        public List<List<string>> ImmobList = new List<List<string>>();

        public virtual void AddElement() { }
        public virtual void NonMoved() { }
        public virtual void MoveBy() { }
        public virtual void ShowDetails() { }
        public virtual void DeleteElement(){}
        public virtual void ShowLessDetails(){}
        public virtual void DeleteMobile(){}
        public virtual void DeleteImmobile(){}
        public virtual void DeleteAll(){


        }
    }


}
