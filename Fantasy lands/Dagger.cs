using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_lands
{
    internal class Dagger:iWeapon
    {
        public string Name { get; set; } = "Dagger";
        public int GetDamage()
        {
            Random rmd = new Random();
            int damage = rmd.Next(1,4);
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
            if (critical>= 7)
            {
                return true;
            }
            return false;
        }
    }
}
