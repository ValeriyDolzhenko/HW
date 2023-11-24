//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии

using System;

class Program1
{
   static void PrintNumbers(int n)
   {
       if (n <= 0)
           return;
       Console.Write(n+"\t");
       PrintNumbers(n - 1);
   }

   static void Main(string[] args)
   {
       int n = 10;
       PrintNumbers(n);
   }
}