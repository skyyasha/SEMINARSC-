// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// void secondnum(int num)
// {
//    int resalt = num / 10;
//    resalt = resalt % 10;
//    Console.WriteLine(resalt);
// }

// int num = new Random().Next(100, 1000); // записывает в num рандомное число от 100 до 999
// Console.WriteLine(num);
// secondnum(num);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// void tirdnumber(int num)
// {
//    if (num > 99)
//    {
//    int resalt = num / 10;
//    resalt = resalt / 10;
//    resalt = resalt % 10;
//    Console.WriteLine($"Третья цифра числа {num} это {resalt}");
//    }
//    else
//    {
//       Console.WriteLine($"{num} < 100");
//    }
// }

// Console.WriteLine("input Namber");
// int num = Convert.ToInt32(Console.ReadLine());

// tirdnumber(num);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// void weeks(int num)
// {
//    if (num > 7)
//    {
//       Console.WriteLine("Введены некорректные данные");
//    }
//    else
//    {
//    if (num ==6 || num == 7)
//    {
//       Console.WriteLine("Ура, выходные!!!");
//    }
//    else
//    {
//       Console.WriteLine("Опять работать(");

//    }
//    }
// }

// Console.WriteLine("Введите день недели.");
// int num = Convert.ToInt32(Console.ReadLine());

// weeks(num);