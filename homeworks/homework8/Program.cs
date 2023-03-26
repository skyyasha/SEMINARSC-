// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. array[строка, столбец]
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int[,] CreateNewArray(int i, int j, int min, int max)
// {
//    int[,] array = new int[i, j];
//    Random random = new Random();
//    for (i = 0; i < array.GetLength(0); i++)
//    {
//       for (j = 0; j < array.GetLength(1); j++)
//       {
//          array[i, j] = new Random().Next(min, max);
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

// void OrderArrayLines(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
// }


// Console.WriteLine("Input col");
// int row = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("input row");
// int col = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input min value");
// int minValue = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("input max value");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = CreateNewArray(row, col, minValue, maxValue);


// ShowArray(myArray);
// Console.WriteLine($"\nОтсортированный массив: ");
// OrderArrayLines(myArray);
// ShowArray(myArray);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] CreateNewArray(int i, int j, int min, int max)
// {
//    int[,] array = new int[i, j];
//    Random random = new Random();
//    for (i = 0; i < array.GetLength(0); i++)
//    {
//       for (j = 0; j < array.GetLength(1); j++)
//       {
//          array[i, j] = new Random().Next(min, max);
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

// // int SumString(int[,] array)
// // {
// //    for (int i = 0; i < array.GetLength(0); i++)
// //    {
// //       int sum = 0;
// //       for (int j = 0; j < array.GetLength(1); j++)
// //       {
// //          sum += array[i, j];
// //       }
// //       Console.WriteLine($"Sum {i} -> {sum}");
// //    }
// // }

// void MinSumLine(int[,] array)
// {
//    int sum = int.MaxValue;
//             int index = 0;
//             for (int i = 0; i < array.GetLength(0); i++)
//             {
//                 int temp = 0;
//                 for (int j = 0; j < array.GetLength(1); j++)
//                 {
//                     temp += array[i, j];
//                 }
//                 if (temp < sum)
//                 {
//                     sum = temp;
//                     index = i;
//                 }
//                 Console.WriteLine($"Sum {i} -> {temp}");
//             }
//             Console.WriteLine($"min -> {sum}");
// }

// Console.WriteLine("Input col");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input row");
// int col = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input min value");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input max value");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateNewArray(row, col, minValue, maxValue);


// ShowArray(myArray);
// MinSumLine(myArray);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] CreateNewArray(int i, int j, int min, int max)
// {
//    int[,] array = new int[i, j];
//    Random random = new Random();
//    for (i = 0; i < array.GetLength(0); i++)
//    {
//       for (j = 0; j < array.GetLength(1); j++)
//       {
//          array[i, j] = new Random().Next(min, max);
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
//    Console.WriteLine();
// }

// void Myltiplicftion(int[,] matrix1, int[,] matrix2, int row, int col)
// {
//    int i = row;
//    int j = row;
//    int[,] arrayMylti = new int[i, j];
//    for(i = 0; i < arrayMylti.GetLength(0); i++)
//    {
//       for(j = 0; j < arrayMylti.GetLength(0); j++)
//       {
         
//          for (row = 0; row < matrix1.GetLength(0); row++)
//          {
//             arrayMylti[i,j] = 0;
//              for (col = 0; col < matrix1.GetLength(1); col++)
//             {
//                 arrayMylti[i,j] = arrayMylti[i,j] + (matrix1[row,col] * matrix2[col, row]);
//             }
//              Console.Write($"{ arrayMylti[i,j]} ");
//          }
//          Console.WriteLine();
//       }
//    }
// }


// Console.WriteLine("Input row");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input col");
// int col = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input min value");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input max value");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] matrix1 = CreateNewArray(row, col, minValue, maxValue);
// int[,] matrix2 = CreateNewArray(col, row, minValue, maxValue);

// ShowArray(matrix1);
// ShowArray(matrix2);
// Myltiplicftion(matrix1, matrix2, row, col);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] CreateNewArray(int i, int j, int k, int min, int max)
// {
//    int[,,] array = new int[i, j, k];
//    Random random = new Random();
//    for (i = 0; i < array.GetLength(0); i++)
//    {
//       for (j = 0; j < array.GetLength(1); j++)
//       {
//          for (k = 0; k < array.GetLength(2); k++)
//          array[i, j, k] = new Random().Next(min, max);
//       }
//    }
//    return array;
// }

// void ShowArray(int[,,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          for (int k = 0; k < array.GetLength(2); k++)
//          Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
//       }
//       Console.WriteLine();
//    }
//    Console.WriteLine();
// }

// Console.WriteLine("Input row");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input col");
// int col = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input k");
// int k = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input min value");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input max value");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,,] array3D = CreateNewArray(row, col, k, minValue, maxValue);

// ShowArray(array3D);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

 int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}