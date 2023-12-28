// Задача 1: Напишите программу, которая на вход принимает два
// числа и выдаёт, какое число большее, а какое меньшее.
// a=5;b=7 => max=7, min=5
// a=2;b=10 => max=10, min=2
// a=-9;b=-3 => max=-3, min=-9

using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже
    if (firstNumber < secondNumber)
    {
        Console.WriteLine("Первое число " + "`" + firstNumber + "`" + " меньше чем второе число " + "`" + secondNumber + "`");
    }
    else if (secondNumber < firstNumber)
    {
        Console.WriteLine("Первое число " + "`" + firstNumber + "`" + " больше чем второе число " + "`" + secondNumber + "`");
    }
    if (secondNumber == firstNumber)
    {
        Console.WriteLine("Введенные числа равны " + "`" + firstNumber + "`");
    }
    }

  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 3;
            secondNumber = 3;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}