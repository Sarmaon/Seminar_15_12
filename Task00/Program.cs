// Task00 
// Напишите программу, которая на 
// 1. вход принимает число и 
// 2. выдаёт его квадрат (число// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write.Line("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;

Console.WriteLine($"Квадрдат числа {number} = {square}");