using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16102023.Models
{
    public class Knife : IWeapon, INotShootable
    {
        public void MakeDamage()
        {
            throw new NotImplementedException();
        }

        public void NotShoot()
        {
            throw new NotImplementedException();
        }
    }
}
