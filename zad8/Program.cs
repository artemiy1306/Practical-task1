﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear(); 
Console.WriteLine("Введите число "); 
int number = Convert.ToInt32(Console.ReadLine());
int a = 1;
while(a < number){
      if(a % 2 == 0 ){
      Console.Write(a + ", ");
} 
     a++;
}
