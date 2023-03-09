// Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа
// 78 -> 8
// 12 ->2
// 85 ->8

// void MaxDecimal(int num)
// {
//    int ed = num % 10;
//    int dec = num / 10;
//    if (ed > dec)
//    {
//       Console.WriteLine($"Большая цифра числа {num} -> {ed}");
//    }
//    else
//    {
//       Console.WriteLine($"Большая цифра числа {num} -> {dec}");
//    }
// }

// int num = new Random().Next(10, 100); // записывает в num рандомное число от 10 до 99

// MaxDecimal(num);

// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
// 456 -> 46
// 782 -> 72
// 918 -> 18

// int DeleteDecimal(int num)
// {
//    int sot = num / 100;
//    int ed = num % 10;
//    return sot * 10 + ed;
// }


// int num = new Random().Next(100, 1000);

// Console.WriteLine(num);

// Console.WriteLine(DeleteDecimal(num));

// напишите на вход программу которая принимает число и проверяет кратно ли оно одновременно 7 и 23
// 161

// void Devid723Decimal(int num)
// {
//    if (num % 7 == 0 && num % 23 == 0) // && объединение 2-х условий
//    {
//       Console.WriteLine("Всё отлично!");

//    }
//    else
//    {
//       Console.WriteLine("Попробуйте ещё!!!");
//    }
// }
// Console.WriteLine("Input num");
// int num = Convert.ToInt32(Console.ReadLine());

// Devid723Decimal(num);


// напишите программу которая принимает на вход 2 числа и выводить является ли одно кратным другому

void Kratnost(int num1, int num2)
{
   if (num1 % num2 == 0)
   {
      Console.WriteLine($"{num1} кратно {num2}");
   }
   else
   {
      Console.WriteLine($"Остаток от деления равен {num1 % num2}");
   }
}

Console.WriteLine("Input firstn");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input num2");
int num2 = Convert.ToInt32(Console.ReadLine());

Kratnost(num1, num2);