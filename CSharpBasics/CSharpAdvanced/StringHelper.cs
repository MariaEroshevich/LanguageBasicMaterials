using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public static class StringHelper
    {
        public static int GetCharCount(this string baseString, char symbolToFind)
        {
            int counter = 0;
            for (int i = 0; i < baseString.Length; i++)
            {
                if (baseString[i] == symbolToFind)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
