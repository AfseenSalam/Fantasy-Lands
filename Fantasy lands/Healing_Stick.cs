using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_lands
{
    internal class Healing_Stick:iWeapon
    {
        public string Name { get; set; } = "Healing_Stick";
        public int GetDamage()
        {
            return 2;
        }
        public int GetHealing()
        {
            return 2;
        }
        public bool IsCritical()
        {
            Random rmd = new Random();
            int critical = rmd.Next(1, 11);
            if (critical >= 9)
            {
                return true;
            }
            return false;
        }
    }
}
