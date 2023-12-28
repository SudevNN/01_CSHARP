// Домашнее задание:
// Задача 3: Напишите программу, которая принимает на вход 
// целое число из отрезка [10, 99] и показывает наибольшую 
// цифру числа.
// 40 => 4
// 96 => 9
// 72 => 7

Console.Write("Введите число из отрезка [10, 99] : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10 || number > 100)
{
    Console.WriteLine($"Ошибка: введенное число не входит в отрезок [10, 99]");
}
else
{
    int firstDigit = number / 10 % 10;
    int secondDigit = number % 10;
    if (firstDigit > secondDigit)
    {
        Console.WriteLine($"Наибольшая цифра числа {number} -> {firstDigit} ");
    }
    else
    {
        Console.WriteLine($"Наибольшая цифра числа {number} -> {secondDigit} ");
    }
}