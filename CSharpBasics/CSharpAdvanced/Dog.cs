using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public abstract class Dog
    {
        public Dog(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public abstract void Bark();

        //public virtual void Bark(int count)
        //{
        //    for (int i = 0; i < count; i++)
        //        Bark();
        //}

        public bool IsVaccinated { get; set; }

        public void SetVaccinationStatus(dynamic isVaccinated)
        {
            if (isVaccinated is string)
            {
                if (isVaccinated.Equals("Yes"))
                {
                    IsVaccinated = true;
                }
                else if (isVaccinated.Equals("No"))
                {
                    IsVaccinated = false;
                }
                else
                {
                    throw new ArgumentException("Illegal vaccinated value!");
                }
            }
            else if (isVaccinated is bool)
            {
                IsVaccinated = isVaccinated;
            }
            else
            {
                throw new ArgumentException("Illegal vaccinated value!");
            }
        }
    }
}
