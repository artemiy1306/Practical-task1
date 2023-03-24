// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.Clear(); 
Console.Write("Введите A: "); 
int numberA = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите B: "); 
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA == numberB){
  Console.WriteLine("A равно B");
}
else
  if(numberA > numberB){
     Console.WriteLine("A больше B");
     Console.WriteLine($"max = {numberA}");
}  
  else{
    Console.WriteLine("A меньше B");
     Console.WriteLine($"max = {numberB}");
  }
     