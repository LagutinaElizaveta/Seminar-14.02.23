// Случайная генерация трехзначного числа и вывод первой и последней цифры 2 вариант
int num = new Random().Next(100, 1000);
                                                            // int a1 = num / 100;
                                                            // int a2 = num % 10;
Console.WriteLine($"{num}  ->  {num / 100}{num % 10}");     // Console.WriteLine($"{num}  ->  {a1}{a2}");