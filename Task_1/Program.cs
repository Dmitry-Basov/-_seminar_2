﻿// // Напишите программу, которая принимает на вход трёхзначное число 
// и удаляет вторую цифру этого числа.

using System.Reflection;

Console.Write("введите положительное трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    int firstDigit = num / 100;   //256 / 100 = 2.56 = 2
    int thirdDigit = num % 10;    //256 % 10 = 250 + 6 = 6

    int result = firstDigit * 10 + thirdDigit;

    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Некорректный ввод!");
}