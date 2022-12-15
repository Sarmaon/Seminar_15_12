// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

 Console.WriteLine("Введите первое число ");
 int number1 = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите второе число ");
 int number2 = Convert.ToInt32(Console.ReadLine());

 int square = number2 * number2;

     if (square == number1)
 Console.WriteLine("Да");
 else Console.WriteLine("Нет");