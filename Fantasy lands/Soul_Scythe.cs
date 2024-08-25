using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_lands
{
    internal class Soul_Scythe:iWeapon
    {
        public string Name { get; set; } = "Soul_Scythe";
        public int GetDamage()
        {
            Random rmd = new Random();
            int damage = rmd.Next(4, 9);
            return damage;
        }
        public int GetHealing()
        {
            Random rmd = new Random();
            int healing = rmd.Next(0, 2);
            return healing;
        }
        public bool IsCritical()
        {
            Random rmd = new Random();
            int critical = rmd.Next(1, 11);
            if (critical >= 6)
            {
                return true;
            }
            return false;
        }
    }
}
