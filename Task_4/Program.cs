// Напишите программу, которая выводит третью слева
// цифру заданного числа или сообщает, что третьей
// цифры нет.



Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 || num <= -100)
{
    while (num > 999 || num < -999)
    {
        num = num / 10;
    }
    int result = num % 10;
    Console.WriteLine("третья цифра " + result);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
