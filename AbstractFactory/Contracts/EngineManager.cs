using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Contracts
{
    public class EngineManager
    {
        private readonly IFactory _factory;
        public EngineManager(IFactory factory)
        {
            _factory = factory;
        }

        public void RunAllEngines()
        {
            _factory.CreateTruck().EngineStart();
            _factory.CreateCar().EngineStart();
        }
    }
}
