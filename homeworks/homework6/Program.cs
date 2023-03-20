// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// int[] GenerationArray(int size, int minValue, int maxValue)
// {
//    int[] array = new int[size];
//    for (int i = 0; i < size; i++)
//    {
//       array[i] = new Random().Next(minValue, maxValue + 1);
//    }
//    return array;
// }
// void ShowArray(int[] array) //вывод массива на экран
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       Console.Write(array[i] + " ");
//    }
//    Console.WriteLine();
// }

// void QuantityPositiveNumbers(int[] array)
// {
//    int quantity = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//        if(array[i] > 0) quantity += 1;
//    }
//    Console.WriteLine($"Quantity positive numbers -> {quantity}");
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = GenerationArray(size, minValue, maxValue);
// ShowArray(myArray);
// QuantityPositiveNumbers(myArray);



