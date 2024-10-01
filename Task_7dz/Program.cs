// Напишите программу, которая принимает на вход целое число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.



Console.WriteLine("Введите двухзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 10 && num <= 99)
{
    int firstnumber = num / 10;
    int secondnumber = num % 10;
    if (firstnumber < secondnumber)
    {
        Console.WriteLine(secondnumber);
    }
    else
    {
        Console.WriteLine(firstnumber);
    }
}
else
{
    Console.WriteLine("Некорректные данные");
}