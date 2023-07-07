using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class OS
    {
        private static OS _instance;
        
        public string Name { get; private set; }

        private OS(string name)
        {
            this.Name = name;
        }

        public static OS GetInstance(string name)
        {
            if (_instance == null)
            {
                _instance = new OS(name);
            }

            return _instance;
        }
    }
}
