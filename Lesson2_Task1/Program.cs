// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
// "&&" = "И": апельсины И яблоки (покупаем и то, и другое)
// "||" = "ИЛИ": апельсины ИЛИ яблоки(что-то одно, либо все вместе)
if (number >= 100 && number <= 999)
{
    int firstDigit = number / 100; // 275 / 100 = 2
    int thirdDigit = number % 10; // 275 % 10 = 5
    int result = firstDigit * 10 + thirdDigit;// 2 * 10+ 5 = 25
    //$"Текст {firstDigit} текст {firstDigit * 10 + thirdDigit}"
    Console.WriteLine($"Результат: {number} => {result}");
}
else
{
    Console.WriteLine("Число не трехзначное ИЛИ отрц.");
}