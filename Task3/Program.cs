//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

using System;

public class Program3
{
    static int A(int n, int m)
    {
        if (n < 0 || m < 0) {
            Console.WriteLine("Ошибка");
        }
        if (n == 0) return m + 1;
        if (m == 0) return A(n - 1, 1);
        return A(n - 1, A(n, m - 1));
    }

   public static void Main()
   {
       Console.WriteLine(A(3, 2));
   }
}