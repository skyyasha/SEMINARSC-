// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void ShowNumbers(int n)
// {
//    if (n > 1)
//    {
//       Console.WriteLine(n + " ");
//       ShowNumbers(n - 1);
//    }
// }

// Console.WriteLine("Input N:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" ");

// ShowNumbers(n);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumNumbers(int m, int n)
// {
//       int sum = m;
//       if (m == n)
//          return n;
//       if (m < n)
//       {
//          m++;
//          sum += SumNumbers(m, n);
         
//       }
//       return sum;
// }

// Console.WriteLine("Input N:");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input M:");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Sum of [{m}, {n}] -> {SumNumbers(m, n)}");

// // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// //m = 2, n = 3 -> A(m,n) = 9
// // m = 3, n = 2 -> A(m,n) = 29

int FunctionAccermana(int m, int n)
{
   if (m == 0)
   {
      return n + 1;
   }
   else if ((m > 0) && (n == 0))
   {
      return FunctionAccermana(m - 1, 1);
   }
   else
   {
      return FunctionAccermana(m - 1, FunctionAccermana(m, n - 1));
   }
}

Console.WriteLine("Input M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input N:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"M ={m}, N = {n}-> {FunctionAccermana(m, n)}");