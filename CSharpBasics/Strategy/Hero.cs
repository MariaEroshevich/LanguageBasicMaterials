using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Hero
    {
        private string _name;

        private IWeapon _weapon;

        public Hero(string name)
        {
            _name = name;
        }

        public void SetWeapon(IWeapon weapon)
        {
           _weapon = weapon;         
        }

        //Good realisation
        public void Attack()
        {
            if (_weapon != null)
            {
                Console.WriteLine($"{_name} stands with weapon");
                _weapon.Shoot();
            }
            else
            {
                Console.WriteLine($"{_name} can't attack. Seat a weapon");
            }
        }

        //Bad realization
        //public void Attack(string gunType)
        //{
        //    switch (gunType)
        //    {
        //        case "Gun":
        //            Console.WriteLine("Attack with gun");
        //            break;
        //    }
        //}
    }
}
