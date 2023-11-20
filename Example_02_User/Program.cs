// Console.WriteLine("введите число");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите 2 число");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber % secondNumber == 0)
// {
//     Console.WriteLine("кратно");
// }
// else
// {
//     Console.WriteLine($"не кратно, остаток {firstNumber % secondNumber}");
// }

// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 7 == 0 && number % 23 == 0)
// {
//     System.Console.WriteLine("Числа кратны");
// }
// else{
//      System.Console.WriteLine("Числа не кратны");
// }

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// Console.Write("Введите число: ");
// int numberF= Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int numberS= Convert.ToInt32(Console.ReadLine());

// if (numberF==numberS*numberS || numberS==numberF*numberF)
// {
//     Console.WriteLine("yes");
// }
// else 
// {
//     Console.WriteLine("no");
// }

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int number = new Random().Next(10, 100); // [10, 100)

// int leftDigit = number / 10;
// int rightDigit = number % 10;

// if (leftDigit > rightDigit)
// {
//     Console.Write($"{number} -> {leftDigit}");
// }
// else
// {
//     Console.Write($"{number} -> {rightDigit}");
// }
// Console.WriteLine();