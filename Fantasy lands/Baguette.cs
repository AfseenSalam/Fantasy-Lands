using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_lands
{
    internal class Baguette:iWeapon
    {
        public string Name { get; set; } = "Baguette";
        public int GetDamage()
        {
            return 1;
        }
        public int GetHealing()
        {
            Random rmd = new Random();
            int healing = rmd.Next(2, 9);
            return healing;
        }
        public bool IsCritical()
        {
            return false;
        }

    }
}
