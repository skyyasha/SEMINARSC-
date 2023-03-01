// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int quad = num2 * num2;
// if(quad == num1)
// {
//    Console.WriteLine("First numbers is quad of second number");
// } 
// else
// {
//    Console.WriteLine("First numbers is not quad of second number");
// }
            //Задача3
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());

// int current = num * (-1);

// while (current <= num)
// {
//    Console.Write(current + " ");
//    current++; // == current + 1
// }

                     
Console.WriteLine("Input number three-didgit number");
int num = Convert.ToInt32(Console.ReadLine());

int resalt = num % 10;

Console.WriteLine($"Last number of {num} is {resalt}");