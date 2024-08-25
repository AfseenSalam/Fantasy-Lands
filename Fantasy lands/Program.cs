using Fantasy_lands;
Console.WriteLine("=====================");
Console.WriteLine("Fantasy Land");
Console.WriteLine("=====================");
Console.WriteLine("Welcome to the Fantasy Land");
Console.WriteLine("Enter the user name:");
string? userName = Console.ReadLine();
Console.WriteLine($"{userName} have to fight 5 monsters to get out with their trusty sword");
Player player = new Player(userName, 10)
{
    CurrentWeapon = WeaponFactory.GetWeapon("Sword")
};
for (int i =1;i<=5;i++)
{
    Monster monster = Monster.GetRandomMonster();
    Console.WriteLine($"{monster.Name} fight number is{i}");
    Console.WriteLine($"{userName} press enter to continue");
    Console.ReadLine();
    while (player.Health>0 && monster.Health>0)
    {
        Console.WriteLine($"Player health:{player.Health} and monster health :{monster.Health}");
        int damage = player.GetDamage();
        monster.TakeDamage(damage);
        Console.WriteLine($"Monster Health {monster.Health}");
        int playerHealing = player.GetHealing();
        if (playerHealing>0)
        {
            Console.WriteLine($"{userName} has healed {playerHealing} {player.CurrentWeapon.Name}");
        }
        int monsterDamage = monster.GetDamage();
        player.TakeDamage(monsterDamage);
        Console.WriteLine($"Players health :{player.Health}");
        Console.WriteLine("Press enter to continue:");
        Console.ReadLine();
    }
    if (player.Health<=0)
    {
        Console.WriteLine($"{userName} is died");
        System.Environment.Exit(1);
    }
    else
    {
        Console.WriteLine($"{userName} defeated the monster");
    }
    iWeapon weapon = monster.GetLoot();
    Console.WriteLine($"{weapon.Name} you got it do you want to equip?yes/no:");
    if (Console.ReadLine() == "yes")
    {
        player.CurrentWeapon = weapon;
    }
}
Console.WriteLine("You won the game!!!!");