using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Hequipment
    {
        private readonly Dictionary<Actions,EquipmentFactory> _factory;
        public Hequipment() {
            _factory = new Dictionary<Actions, EquipmentFactory>
            {
                {Actions.Mobile,new MobileFactory() },
                {Actions.Immobile,new ImmobileFactory() }
            };

        }
     

        public Equipment ExecuteCreation(Actions action, string name, string desc, int dist, int cost, int weighte, int wheels) => _factory[action].Create(name, desc, dist, cost, weighte, wheels);
        

    }
    
    
}
