// // Урок5

// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

// Int CreateNewArray(int size, int minValue, int maxValue) //Создание массива
// {
//    Int[] array = new int[size];
//    for (i = 0; i < size; i++)
//    {
//       array[i] = new Random().Next(minValue, MaxValue + 1);
//    }
//    return array
// }

// void ShowArray(int[] array) //вывод массива на экран
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       Console.Write(array[i] + " ");
//    }
//    Console.WriteLine();
// }

// Void EvenQuantity(int[] array)
// {
//    Int evenquantity = 0;
// for (i = 0; i < array.Length; i++)
// {
//     if(array[i] % 2 == 0)  
//     {
//       evenquantity++;
//     }
// }
//    Console.WriteLine($"Колличество четных чисел в массиве = { evenquantity} ");
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateNewArray(size, minValue, maxValue);
// ShowArray(myArray);
// EvenQuantity(myArray);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0

// Int CreateNewArray(int size, int minValue, int maxValue) //Создание массива
// {
//    Int[] array = new int[size];
//    for (i = 0; i < size; i++)
//    {
//       array[i] = new Random().Next(minValue, MaxValue + 1);
//    }
//    return array
// }

// void ShowArray(int[] array) //вывод массива на экран
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       Console.Write(array[i] + " ");
//    }
//    Console.WriteLine();
// }

// void SumOdd(int[] array)
// {
//    int sum = 0;
//    for (i = 0; i < array.Length; i++)
//    {
//       if (i % 2 == 1)
//       {
//          Sum += array[i];
//       }
//    }
//    Console.WriteLine($"Sum of odd indices-> { sum}");
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateNewArray(size, minValue, maxValue);
// ShowArray(myArray);
// SumOdd(myArray);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double CreateNewArray(int size, int minValue, int maxValue) //Создание массива
{
   double[] array = new double[size];
   for (i = 0; i < size; i++)
   {
      array[i] = new Random().Next(minValue, MaxValue + 1);
   }
   return array;
}

void ShowArray(double[] array) //вывод массива на экран
{
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write(array[i] + " ");
   }
   Console.WriteLine();
}

Void MaxMinDiff(double[] array)
{
   double max = array[0];
   double min = array[0];
   double diff = 0;
   for (i = 0; i < array.Length; i++)
   {
      if(array[i] > max)
   {
         max = array[i];
      }
   }
   for (i = 0; i < array.Length; i++)
   {
      if(array[i] < min) 
      {
         min = array[i];
      }
   }
   diff = max - min;
Console.WriteLine($"Difference of max and min numbers of array-> { diff}");
}

Console.WriteLine("Input array size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value of array");
double minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value of array");
double maxValue = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateNewArray(size, minValue, maxValue);
ShowArray(myArray);
MaxMinDiff(myArray);



