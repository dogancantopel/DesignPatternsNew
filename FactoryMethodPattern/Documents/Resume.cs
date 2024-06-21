using FactoryMethodPattern.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Documents
{
    public class Resume : Document
    {
        public override void Print()
        {
            Console.WriteLine("Printing Resume...");
        }
    }
}
