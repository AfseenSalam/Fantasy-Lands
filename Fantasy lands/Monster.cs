using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Fantasy_lands
{
    internal class Monster : Character
    {
        public int MaxDmg { get; set; }
        public int MinDmg { get; set; }
        public List<string> Loot { get; set; }

        public Monster(string _name, int _health, int _max, int _min, List<string> _loot) : base(_name, _health)
        {
            MaxDmg = _max;
            MinDmg = _min;
            Loot = _loot;
        }
        public override int GetDamage()
        {
            Random rmd = new Random();
            return rmd.Next(MinDmg, MaxDmg);
        }
        public override void TakeDamage(int dmg)
        {
            Health -= dmg;
        }
        public iWeapon GetLoot()
        {
            Random rmd = new Random();
            string loot = Loot[rmd.Next(Loot.Count)];
            return WeaponFactory.GetWeapon(loot);
        }
        public static List<Monster> monsters = new()
            {new Monster("Goblin",4,3,1,new List<string> {"Sword", "Dagger", "Baguette" }),
            new Monster("Chef",2,1,1,new List<string> { "Baguette"}),
            new Monster("Thief",5,4,2,new List<string> {"Dagger","Flame_Dagger"}),
            new Monster("Wizard",5,6,2,new List<string> {"Healing_Stick","Baguette"}),
            new Monster("Fighter",7,5,3,new List<string> {"Sword", "Dagger", "Flame_Dagger", "Moonlit_Spear" }),
            new Monster("Reaper",10,8,4,new List<string> {"Soul_Scythe" })           
            };
        public static Monster GetRandomMonster()
        {
            Random rmd = new Random();
            return monsters[rmd.Next(monsters.Count)];
        }
    }
}
