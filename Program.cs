int Input(string text)   //метод приема данных с преобразованием в int
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArray(int [] array, int minValue = -9, int maxValue =9) //метод заполнения массива, введенные значения параметров minValue и  maxValue позволяют делать эти параметры не 
                                                                //обязательными к заполнению
{ 
    maxValue++; //т.к. верхняя граница не включается
    Random rnd = new Random(); // вызов конструктора для заполнения рондомными числами
    for (int i = 0; i < array.Length; i++) // заполняем массив  numbers.Length - размер массива
    {
        array[i] = rnd.Next(minValue, maxValue); //верхняя граница не включается
    }
}
void FillArrayDouble(double [] array, int minValue = -9, int maxValue =9) //метод заполнения массива, введенные значения параметров minValue и  maxValue позволяют делать эти параметры не 
                                                                //обязательными к заполнению
{ 
    maxValue++; //т.к. верхняя граница не включается
    Random rnd = new Random(); // вызов конструктора для заполнения рондомными числами
    for (int i = 0; i < array.Length; i++) // заполняем массив  numbers.Length - размер массива
    {
        array[i] = rnd.NextDouble()*(maxValue-minValue)+minValue;//верхняя граница не включается rnd.NextDouble() - выводит значения от 0 до 1, для увеличения диапазана приведены след ариф действия
        array[i] = Math.Round(array[i],2);
    }
}
void PrintArray(int[] array) //метод вывода массива
{
    for (int i = 0; i < array.Length; i++) // заполняем массив  numbers.Length - размер массива  
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void PrintArrayDouble(double[] array) //метод вывода массива
{
    for (int i = 0; i < array.Length; i++) // заполняем массив  numbers.Length - размер массива  
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}//

void Task34()
{
  Console.Clear();
    Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");

    int size = 9; // указываем размер будущего массива
    int[] numbers = new int[size]; //[] - обозначаем массив, начальный индекс массива =0
    FillArray(numbers,100,999);
    PrintArray(numbers);
    Console.WriteLine();
    int col =0;
    
      for (int i = 0; i < numbers.Length; i++)
    {
      if (numbers[i]%2==0) 
        { 
         col++;
        }
    }
   Console.Write($"{col} четных элементов массива");
   Console.WriteLine();
}
Task34();

void Task36()
{
    Console.WriteLine("\n Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.");

    int size = 5; // указываем размер будущего массива
    int[] numbers = new int[size]; //[] - обозначаем массив, начальный индекс массива =0
    FillArray(numbers,-3,25);
    PrintArray(numbers);
    Console.WriteLine();
    int Sum =0;
    
      for (int i = 0; i < numbers.Length; i++)
    {
      if (i%2!=0) 
        { Console.Write($"{numbers[i]}+");
         Sum=Sum+numbers[i];
         }
    }
   Console.Write($" \b\b = {Sum}");
}
Task36();

void Task38()
{
    Console.WriteLine(" \n Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива");
    int size = 8; // указываем размер будущего массива
    double [] numbers = new double[size]; //[] - обозначаем массив, начальный индекс массива =0
    FillArrayDouble(numbers,-3,25);
    PrintArrayDouble(numbers);
    Console.WriteLine();
    double D =0;

    for (int i = 0; i < numbers.Length - 1; i++)
    {
        for (int a = 0; a < numbers.Length - i - 1; a++)
        {
            if (numbers[a] >numbers[a + 1])
            {
                double temp = numbers[a];
                numbers[a] = numbers[a + 1];
                numbers[a + 1] = temp;
            }

        }

    }
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    D=Math.Round((numbers[numbers.Length-1]-numbers[0]),2);
 Console.Write($"\n Разница между максимальным и минимальным элементами массива {D}");
}
Task38();



