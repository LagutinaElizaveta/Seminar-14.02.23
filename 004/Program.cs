// Одновременное условие
Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());
if ((num % 7 == 0) && (num % 23 == 0))
{
    Console.WriteLine("Число кратно 7 и 23");
}
else
{
    Console.WriteLine("Число не кратно 7 и (или) 23");
}
