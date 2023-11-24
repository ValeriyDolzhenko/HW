//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

using System;

public class Program2
{
   public static void Main()
   {
       int M = 1;
       int N = 15;
       Console.WriteLine("M="+M+" N="+N+": "+SumOfNaturalNumbers(M, N));
   }

   static int SumOfNaturalNumbers(int M, int N)
   {
       if (M > N)
       {
           return 0;
       }
       else
       {
           return M + SumOfNaturalNumbers(M + 1, N);
       }
   }
}