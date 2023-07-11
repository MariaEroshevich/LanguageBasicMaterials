using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public static class DogHelper
    {
        public static string GetTrimmedName(this Dog dog)
        {
            return dog.Name.Trim();
        }
    }
}
