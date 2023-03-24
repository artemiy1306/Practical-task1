// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear(); 
Console.Write("Введите A: "); 
int numberA = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите B: "); 
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: "); 
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberA > max ) max = numberA;
if (numberB > max ) max = numberB;
if (numberC > max ) max = numberC;
Console.WriteLine($"max = {max}");
