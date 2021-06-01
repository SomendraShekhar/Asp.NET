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

            //foreach(Actions action in Enum.GetValues(typeof(Actions)))
            //{
              //  var factory = (EquipmentFactory)Activator.CreateInstance(Type.GetType("FactoryMethod." + Enum.GetName(typeof(Actions), action) + "Factory"));
                //_factory.Add(action, factory);
           // }
        }
       // public static Hequipment InitializeFactories() => new Hequipment();

        public Equipment ExecuteCreation(Actions action, string name, string desc, int dist, int cost, int weighte, int wheels) => _factory[action].Create(name, desc, dist, cost, weighte, wheels);
    }
    
    
}
