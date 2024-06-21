using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Contracts
{
    public abstract class DocumentCreator
    {
        public abstract Document CreateDocument();

        public void PrintDocument()
        {
            var doc = CreateDocument();
            doc.Print();
        }
    }
}
