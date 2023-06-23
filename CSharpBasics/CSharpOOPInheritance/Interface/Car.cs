using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPInheritance.Interface
{
    internal class Car : IMoveble
    {
        private string _typeOfMoveble;

        public Car(string typeOfMoveble)
        {
            _typeOfMoveble = typeOfMoveble;
        }

        public string TypeOfMovement
        {
            get { return _typeOfMoveble; }
            set { _typeOfMoveble = value; }
        }

        public void Move()
        {
            Console.WriteLine("Drive");
        }
    }
}
