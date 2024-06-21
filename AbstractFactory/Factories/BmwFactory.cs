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
    public class BmwFactory :IFactory
    {
        public Car CreateCar()
        {
            return new BmwCar();
        }

        public Truck CreateTruck()
        {
            return new BmwTruck();
        }
    }
}
