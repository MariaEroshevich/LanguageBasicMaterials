﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Computer
    {
        public OS OS { get; set; }

        public void Launch(string osName)
        {
            OS = OS.GetInstance(osName);
        }
    }
}
