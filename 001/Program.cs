﻿// Случайное числ из отрезка и показ наибольшей цифры числа
int num = new Random().Next(10, 100);
int a1 = num / 10;
int a2 = num % 10;
int max = a1;
if (max < a2) max = a2;
Console.WriteLine($"Максимальная цифра числа {num}  ->  {max}");
