using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class AuthorizationBuilder
    {
        public AuthorizationBuilder AddUserName()
        {
            return this;
        }

        public AuthorizationBuilder AddScheme()
        {
            return this;
        }

        public AuthorizationBuilder AddSignature()
        {
            return this;
        }
    }
}
