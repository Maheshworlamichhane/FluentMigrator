﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migration.Factory
{
    public interface IConnectionStringFactory
    {
        string GetConnectionString();
    }
}
