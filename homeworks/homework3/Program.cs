//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

//1.Задать пятизначное число(Запросить у пользователя)
int GetNumber(string text, int[] numbers)
{
      text =  System.Console.WriteLine(text);
      char[] chars = text.ToCharArray();
      int ctr = 0;
      int size = 0;
      while (size < numbers.Length)
      {
         numbers(size) = chars[ctr];
         size++;
         ctr++;
      }
   return Convert.ToInt32(Console.ReadLine());
}
//2.Создать массив
int[] CreateArray(int size = 5)
{
   return new int[size];
}

//3. проверить является ли оно палиндромом
//3.1 Являются ли крайние цифры равными
//3.2 Являются ли средние числа равными
//4. Выдать ответ 
int[] numbers = CreateArray();
int num = GetNumber("Введите 5-ти значное число");



     
      