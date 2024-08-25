using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_lands
{
    internal class Flame_Dagger:iWeapon
    {
        public string Name { get; set; } = "Flame_Dagger";
        public int GetDamage()
        {
            Random rmd = new Random();
            int damage = rmd.Next(3, 6);
            return damage;
        }
        public int GetHealing()
        {
            return 0;
        }
        public bool IsCritical()
        {
            Random rmd = new Random();
            int critical = rmd.Next(1, 11);
            if (critical >= 8)
            {
                return true;
            }
            return false;
        }
    }
}
