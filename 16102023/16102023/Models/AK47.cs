using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16102023.Models
{
    public class AK47 : Gun, IWeapon, IShootable
    {
        //public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public AK47()
        {
            AmmoCount = 30;
        }
        public void MakeDamage()
        {
            Console.WriteLine("20dmg");
        }

        public void Shoot()
        {
            Console.WriteLine("Paw");
        }
    }
}
