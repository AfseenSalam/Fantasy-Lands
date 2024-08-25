using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_lands
{
    internal class Moonlit_Spear:iWeapon
    {
        public string Name { get; set; } = "Moonlit_Spear";
        public int GetDamage()
        {
            return 3;
        }
        public int GetHealing()
        {
            return 2;
        }
        public bool IsCritical()
        {
            return false;
        }
    }
}
