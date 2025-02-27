// written by Mamoutou Kane
// date: 02/06/2025

Console.WriteLine("Enter the enemy's X coordinate:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the enemy's Y coordinate:");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 && y == 0)
    Console.WriteLine("The enemy is here!");
else if (x > 0 && y > 0)
    Console.WriteLine("The enemy is to the northeast!");
else if (x < 0 && y > 0)
    Console.WriteLine("The enemy is to the northwest!");
else if (x > 0 && y < 0)
    Console.WriteLine("The enemy is to the southeast!");
else if (x < 0 && y < 0)
    Console.WriteLine("The enemy is to the southwest!");
else if (x == 0 && y > 0)
    Console.WriteLine("The enemy is to the north!");
else if (x == 0 && y < 0)
    Console.WriteLine("The enemy is to the south!");
else if (x > 0 && y == 0)
    Console.WriteLine("The enemy is to the east!");
else if (x < 0 && y == 0)
    Console.WriteLine("The enemy is to the west!");

