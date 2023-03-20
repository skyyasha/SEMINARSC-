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

// bool CheckTriangle(int x, int y, int z)
// {
//    if (x < y + z && y < x + z && z < x + y)
//    {
//       return true;
//    }
//    return false;
// }

// Console.WriteLine("Input lenght of a");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input lenght of b");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input lenght of c");
// int z = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Does such triangle with sides {x} and {y} and {x} exist?");
// Console.WriteLine($"{CheckTriangle(x, y ,z)}");


// Задача 3. вывести N чисел Фибоначи 
//  С рекурсией

// int Fibonachi(int i)
// {
//    if (i == 1 || i == 2) return 1;
//    else return Fibonachi(i - 1) + Fibonachi(i - 2);

// }

// Console.WriteLine("Input quantity numbers of Fibonachi:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input quantity numbers of start print:");
// int start = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(" ");
// for (int i = start; i <= size; i++ )
// {
//    Console.WriteLine($"{i} -> {Fibonachi(i)}");
// }


 void ShowArray(int[] array, int start)
{
   for (int i = start-1; i < array.Length; i++)
   {
      System.Console.Write($"{array[i]}, ");
   }
}

int[] Fibonachi(int size)
{
   int[] myArray = new int[size];
   myArray[0] = 0;
   myArray[1] = 1;
   for (int i = 2; i < myArray.Length; i++)
   {
      myArray[i] = myArray[i - 1] + myArray[i - 2];
   }
   return myArray;
}

Console.WriteLine("Input size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input start print number");
int start = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input lenght of a");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input lenght of b");
// int b = Convert.ToInt32(Console.ReadLine());

int[] fibonachi = Fibonachi(size);
ShowArray(fibonachi, start);