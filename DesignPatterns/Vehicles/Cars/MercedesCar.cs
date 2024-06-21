using AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Vehicles.Cars
{
    public class MercedesCar : Car
    {
        public override void EngineStart()
        {
            Console.WriteLine("Mercedes engine has been started");
        }
    }
}
