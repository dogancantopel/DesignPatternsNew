using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        public static Singleton instance;
        private static readonly object _lock = new ();
        
        public static Singleton GetInstance()
        {
            if(instance == null)
            {
                lock (_lock)
                {
                    instance = instance ?? new Singleton(); 
                }
            }

            return instance;
        }

        public void SomeMethod()
        {
            Console.WriteLine("Singleton method called.");
        }
    }
}
