// Напишите программу, которая принимает на вход координаты точки (X и Y),
//  причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
//  в которой находится эта точка.


Console.WriteLine("input X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Четверть 1");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine("Четверть 2");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Четверть 3");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Четверть 4");
}
else
{
    Console.WriteLine("Некорректные координаты");
}
