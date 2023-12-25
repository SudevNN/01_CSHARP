// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 4
// 7812 => 8
// 91 => Третьей цифры нет
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int copyNumber = number;

if (number < 100)
{
    Console.WriteLine("Число не трехзначное ИЛИ отрц.");
}

else // В числе >= 3 знака
{   
    Console.WriteLine($"Третья цифра от {copyNumber} (справа) =  {number / 100 % 10}");
}
