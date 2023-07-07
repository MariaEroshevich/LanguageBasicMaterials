using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class WaterGun : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("Attack with water gun");
        }
    }
}
