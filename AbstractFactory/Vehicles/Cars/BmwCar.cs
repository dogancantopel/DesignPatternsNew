using AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Vehicles.Cars
{
    public class BmwCar : Car
    {
        public override void EngineStart()
        {
            Console.WriteLine("BMW engine has been started");
        }
    }
}
