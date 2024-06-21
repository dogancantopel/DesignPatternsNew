﻿using FactoryMethodPattern.Contracts;
using FactoryMethodPattern.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Concretes
{
    public class ResumeCreator : DocumentCreator
    {
        public override Document CreateDocument()
        {
            return new Resume();
        }
    }
}
