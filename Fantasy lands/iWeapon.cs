using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_lands
{
    internal interface iWeapon
    {
        public string Name { get; set; }

        public int GetDamage();
        public int GetHealing();
        public bool IsCritical();
        

    }
}
