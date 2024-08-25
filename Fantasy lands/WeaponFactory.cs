using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_lands
{
    internal static class WeaponFactory
    {
        public static iWeapon GetWeapon (string type)
        {

            if (type == "Sword")
            {
                return new Sword();
            }
            else if (type == "Dagger")
            {
                return new Dagger();
            }
            else if (type == "Healing_Stick")
            {
                return new Healing_Stick();
            }
            else if (type == "Flame_Dagger")
            {
                return new Flame_Dagger();
            }
            else if (type == "Moonlit_Spear")
            {
                return new Moonlit_Spear();
            }
            else if (type == "Soul_Scythe")
            {
                return new Soul_Scythe();
            }
            else if (type == "Baguette")
            {
                return new Baguette();
            }
            else
            {
                throw new ArgumentException("Type not found in factory");
            }


        }
       


    }
}
