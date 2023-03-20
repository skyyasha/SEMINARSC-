// Задача 1. Напишите прогрраму которая переворачивает одномерный массив (первый эл-т будет на последнем, а последний на первом) 

//  int[] GenerationArray(int size, int minValue, int maxValue)
// {
//    int[] array = new int[size];
//    Random random = new Random();
//    for (int i = 0; i < size; i++)
//    {
//       array[i] = new Random().Next(minValue, maxValue + 1);
//    }
//    return array;
// }

//  void ShowArray(int[] array)
// {
//    System.Console.WriteLine("[");
//    for (int i = 0; i < array.Length - 1; i++)
//    {
//       System.Console.Write($"{array[i]}, ");
//    }
//       System.Console.Write($"{array[array.Length - 1]}");
//        System.Console.Write("]");
// }

// int[] ReversArray(int[] array)
// {
//    for (int i = 0; i < array.Length / 2; i++)
//    {
//       int temp = array[i];
//       array[i] = array[array.Length - i - 1];
//       array[array.Length - i - 1] = temp;
//    } 
//    return array;
// }

// Console.WriteLine("Input array size");
// int Length = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = GenerationArray(Length, minValue, maxValue);
// ShowArray(myArray);
// int[] reversArray = ReversArray(myArray);
// ShowArray(reversArray);


// Задача 2. ННапишите программу, которая проверяет на вход 3 числа и прроверяет, может ли существовать треугольник со сторонами такой
// длины. самое важное знать правило, каждая сторона должна быть меньше суммы 2-х других сторон.

bool CheckTriangle(int x, int y, int z)
{
   if (x < y + z && y < x + z && z < x + y)
   {
      return true;
   }
   return false;
}

Console.WriteLine("Input lenght of a");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input lenght of b");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input lenght of c");
int z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" Triangle with sides {x} and {y} and {x} exist {CheckTriangle(x, y ,z)}");