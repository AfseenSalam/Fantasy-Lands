using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_lands
{
    internal class Sword:iWeapon
    {
        public string Name { get; set; } = "sword";
        public int GetDamage()
        {
            Random rmd = new Random();
            int damage = rmd.Next(2,5);
            return damage;
        }
        public int GetHealing()
        {
            return 0;
        }
        public bool IsCritical()
        {
            return false;
        }

    }
}
