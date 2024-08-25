using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_lands
{
    internal abstract class Character
    {
        public string Name { get; set;}
        public int Health { get; set; }

        public Character(string _name,int _health)
        {
            Name = _name;
            Health = _health;
        }
        public abstract int GetDamage();
        public abstract void TakeDamage(int dmg);

    }
}
