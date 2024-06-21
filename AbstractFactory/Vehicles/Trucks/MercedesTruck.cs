using AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Vehicles.Trucks
{
    public class MercedesTruck : Truck
    {
        public override void EngineStart()
        {
            Console.WriteLine("MercedesTruck engine has been started");
        }
    }
}
