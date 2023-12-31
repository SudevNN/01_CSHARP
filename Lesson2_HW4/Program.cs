// Домашнее задание:
// Задача 4: Напишите программу, которая на вход принимает 
// натуральное число N, а на выходе показывает его цифры 
// через запятую.
// 568 => 5,6,8
// 8 => 8
// 9542 => 9,5,4,2

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int copyNumber = 0;

    while (number > 0)
        {
            copyNumber = copyNumber * 10;
            copyNumber = copyNumber + (number % 10);
            number = number / 10;
            //Console.Write($"{copyNumber}, ");
        }
    number = copyNumber;
    while (number > 9)
        {
            copyNumber = number % 10;
            number = number / 10;
            Console.Write($"{copyNumber}, ");
        }
        Console.Write($"{number}");


