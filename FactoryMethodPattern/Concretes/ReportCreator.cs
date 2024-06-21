using FactoryMethodPattern.Contracts;
using FactoryMethodPattern.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Concretes
{
    public class ReportCreator : DocumentCreator
    {
        public override Document CreateDocument()
        {
            return new Report();
        }
    }
}
