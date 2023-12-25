// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
// "&&" = "И": апельсины И яблоки (покупаем и то, и другое)
// "||" = "ИЛИ": апельсины ИЛИ яблоки(что-то одно, либо все вместе)
if (number >= 100 && number <= 999)
{
    int secondDigit = number / 10 % 10;
    // 275 / 10 % 10 = 27 % 10 = 7
    int thirdDigit = number % 10; // 275 % 10 = 5
    // Возвести число 7 в 5 степень
    // Math.Pow(2, 3) => 2 в 3 степени: 2 * 2 * 2 = 8
    int result = (int)Math.Pow(secondDigit, thirdDigit);
    Console.WriteLine($"{number} : {secondDigit} ^ {thirdDigit} = {result}");
}
else
{
    Console.WriteLine("Число не трехзначное ИЛИ отрц.");
}