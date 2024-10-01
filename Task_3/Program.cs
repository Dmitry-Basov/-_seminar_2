// Напишите программу, которая будет принимать на вход два
// числа и выводить, является ли первое число кратным второму.
// Если первое число не кратно второму, то программа выводит
// остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1



Console.WriteLine("input first numbers: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int remainder = firstNumber % secondNumber;

if (remainder == 0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no, " + remainder);
}
