﻿// // Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
//  7 и 23.

Console.WriteLine("input  number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
