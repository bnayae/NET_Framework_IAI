﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_ConfigInterfaceDemo
{
    public interface IConfig
    {
        String readProperty(String propName);
    }
}
