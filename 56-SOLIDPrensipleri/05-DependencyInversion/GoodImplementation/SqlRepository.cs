﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_SOLIDPrensipleri._05_DependencyInversion.GoodImplementation
{
    public class SqlRepository : IRepository
    {
        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
