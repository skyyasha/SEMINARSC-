// // // // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // // //3, 5 -> 243 (3⁵)
// // // //2, 4 -> 16

// // // int Promt(string message)
// // // {
// // //    System.Console.Write(message);
// // //    string readInput = System.Console.ReadLine();
// // //    int result = int.Parse(readInput);
// // //    return reslt;
// // // }

// // // int Power(int PowerBase, int exponent)
// // // {
// // //    int power = 1;
// // //    for (int i = 0; i < exponent; i++)
// // //    {
// // //       power *= PowerBase;
// // //    }
// // //    return power;
// // // }

// // // bool ValidateExponent(int exponent)
// // // {
// // //    if (exponent < 0)
// // //    {
// // //       System.Console.WriteLine("Значение не должно быть мпеньше 0");
// // //       return false;
// // //    }
// // //    return true;
// // // }

// // // int PowerBase = Promt("Введите основание: ");
// // // int exponent = Promt("Введите значение: ");
// // // if (ValidateExponent(exponent))
// // // {
// // //    System.Console.WriteLine($"Число {PowerBase} в степени {exponent} Равно {Power(PowerBase, exponent)}");
// // // }

// // // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // // 452 -> 11
// // // 82 -> 10
// // // 9012 -> 12

// // int Promt(string message)
// // {
// //    System.Console.Write(message);
// //    string readInput = System.Console.ReadLine();
// //    int result = int.Parse(readInput);
// //    return result;
// // }

// // int SumAllDigit(int number)
// // {
// //    int result = 0;
// //    while (number > 0)
// //    {
// //       result += number % 10;
// //       number = number / 10;
// //    }
// //    return result;
// // }

// // int number = Promt("Введите число: ");
// // System.Console.WriteLine($"Сумма всех чисел в цифре {number} = {SumAllDigit(number)}");

// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// // 6, 1, 33 -> [6, 1, 33]

// int Promt(string message)
// {
//    System.Console.Write(message);
//    string readInput = System.Console.ReadLine();
//    int result = int.Parse(readInput);
//    return result;
// }

// int GenerationArray(int Length, int minValue, int maxValue)
// {
//    int[] array = new int[Length];
//    Random random = new Random();
//    for (int i = 0; i < Length; i++);
//    {
//       array[i] = random.Next(minValue, maxValue + 1);
//    }
//    return array;
// }

// void PrintArray(int[] array)
// {
//    System.Console.WriteLine("[");
//    for (int i = 0; i < array.Length - 1; i++)
//    {
//       System.Console.Write($"{array[i]}, ");
//    }
//       System.Console.Write($"{array[array.Length - 1]}");
//        System.Console.Write("]");
// }

// int Length = Promt("Длина массива");
// int min = Promt("Начальное значение, для диапазона случайного числа");
// int max = Promt("Конечное значение, для диапазона случайного числа");
// int[] array = GenerateArray(Length, min, max);
// PrintArray(array);