using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_lands
{
    internal class Player:Character
    {
        public iWeapon CurrentWeapon { get; set; }

        public Player(string _name, int _health) : base(_name,_health)
        {
            CurrentWeapon = null;       //Create a constructor that sends name and health back to the base constructor Weapon will be assigned later in the projec

        }
        public override int GetDamage()
        {
            if (CurrentWeapon == null)
            {
                return 1;
            }
            else
            {
                int result = CurrentWeapon.GetDamage();
                if (CurrentWeapon.IsCritical())
                {
                    result *= 2;

                }
                return result;
            }
        }
        public override void TakeDamage(int dmg)
        {
            Health -= dmg;

        }
        public int GetHealing()
        {
            int result = CurrentWeapon.GetHealing();
            result += Health;
            return result;
        }
    }
}
