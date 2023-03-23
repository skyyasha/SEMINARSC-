// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] GenerationArray(int row, int col, int minValue, int maxValue)
// {
//    double[,] array = new double[row, col];
//    for (int i = 0; i < row; i++)
//    {
//       for (int j = 0; j < col; j++)
//       {
//          array[i, j] = new Random().Next(minValue, maxValue + 1) + Math.Round(new Random().NextDouble(), 1);
//       }
//    }
//    return array;
// }
// void ShowArray(double[,] array) //вывод массива на экран
// {
//    for (int i = 0; i < 3; i++)
//    {
//       for (int j = 0; j < 4; j++)
//          Console.Write(array[i, j] + " ");
//       Console.WriteLine();

//    }
//    Console.WriteLine();
// }

// Console.WriteLine("Input array row");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input array col");
// int col = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = GenerationArray(row, col, minValue, maxValue);
// ShowArray(myArray);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет


int[,] CreateNewArray(int min, int max)
{
   int i =3;
   int j = 4;
   int[,] array = new int[i, j];
   Random random = new Random();
   for (i = 0; i < 3; i++)
   {
      for (j = 0; j < 4; j++)
      {
         array[i, j] = new Random().Next(min, max);

      }
   }
   return array;
}

void ShowArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         Console.Write(array[i, j] + " ");
      }
      Console.WriteLine();
   }
   
}

void SelectElement(int row, int col, int[,] array)
{
   if (row >=0 || row < 3 || col >= 0 || col < 4)
   {
      Console.WriteLine($"Element with index ({row}, {col}) is {array[row, col]}");
   }
   else Console.WriteLine("Element with index ({row}, {col}) not expected");
}


Console.WriteLine("Input minimal value of array");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value of array");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateNewArray(minValue, maxValue);
ShowArray(myArray);

Console.WriteLine("Input row");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input column");
int col = Convert.ToInt32(Console.ReadLine());

SelectElement(row, col, myArray);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// int[,] CreateNewArray(int minValue, int maxValue)
// {
//       int i = 3;
//       int j = 4;
//       int[,] array = new int[i, j];
//       Random random = new Random();
//    for (i = 0; i < 3; i++)
//    {
//       for (j = 0; j < 4; j++)
//       {
//          array[i, j] = random.Next(minValue, maxValue + 1);
//       }
//    }
//    return array;

// }

// void ShowArray(int[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          Console.Write(array[i, j] + " ");
//       }
//       Console.WriteLine();
//    }
   
// }

// void Average(int[,] array)
// {
//    int i = 0;
//    int j = 0;
//    for (i = 0; i < 3; i++)
//    {
//       int sum = 0;
//       for (j = 0; j < 4; j++)
//       {
//          sum += array[i, j];
//       }
//       Console.WriteLine($"Average of {i + 1} -> {sum}");
//    }
// }
//    Console.WriteLine("Input min value");
//    int minValue = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("input max value");
//    int maxValue = Convert.ToInt32(Console.ReadLine());
//    int[,] myArray = CreateNewArray(minValue, maxValue);
//    ShowArray(myArray);
//    Average(myArray);
