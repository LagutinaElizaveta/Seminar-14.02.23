﻿// Одно число квадрат другого
Console.WriteLine("Введите первое число ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int num2 = int.Parse(Console.ReadLine());

if ((num1 * num1 == num2) || (num2 * num2 == num1)) // if (Math.Pow(num1, 2) == num2 || Math.Pow(num2, 2) == num1
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}