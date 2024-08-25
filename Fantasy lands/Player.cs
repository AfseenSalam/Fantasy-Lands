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

        }
        

    }
}
