﻿// Даны два действительных числа x и у. 
//Вычислить их сумму, разность, произведение и частное.

double x = new Random().NextDouble(); // генерируем от 0 до 1 с повышенной точностью
double y = new Random().NextDouble();

Console.WriteLine("Генерируем данные числа: ");
Console.WriteLine(x);
Console.WriteLine(y);

Console.Write("Сумма чисел = ");
Console.WriteLine(x + y);

Console.Write("Разность чисел = ");
Console.WriteLine(x - y);

Console.Write("Произведение чисел = ");
Console.WriteLine(x * y);

Console.Write("Частное чисел = ");
Console.WriteLine(x / y);