using AbstractFactory.Contracts;
using AbstractFactory.Vehicles.Cars;
using AbstractFactory.Vehicles.Trucks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class MercedesFactory :IFactory
    {
        public Car CreateCar()
        {
            return new MercedesCar();
        }

        public Truck CreateTruck()
        {
            return new MercedesTruck();
        }
    }
}
