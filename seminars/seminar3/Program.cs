// Реализовать перемешивание массива

//1. Создание массива
int[] CreateArray(int size)
{
   return new int[size];
}
//2.Ввод числа
int GetNumber(string text)
{
   System.Console.WriteLine(text);
   return Convert.ToInt32(Console.ReadLine());

}
//3. Печать массива
string Print(int[] array)
{
   string result = String.Empty;
   int len = array.Length;
   int index = 0;
   while (index < len)
   {
      result = result + " " + array[index];
      index++;
   }
   return result;
}

int size = GetNumber("Введитеразмер массива");

int[] numbers = CreateArray(size);

System.Console.WriteLine(Print(numbers));

//4.заполнение массива

// задача2. Дан массив наполненный от 1 до N 
// Сколько раз какое число встречается?
