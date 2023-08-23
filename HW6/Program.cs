using System.Text.RegularExpressions;

int Input(string text)   //метод приема данных с преобразованием в int
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double InputDouble(string text)   //метод приема данных с преобразованием в int
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
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
}


void Task41()
{
    Console.Clear();
Console.Write (" Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
    
    int N = Input("Сколько чисел вы будете вводить?: "); 
    int Col=0;
    string result = "";
    int a=0; //вводимое число
    for (int i = 1; i<=N; i++)
    { 
      a=Input ($"\n Введите {i} число: ");
      result=result+a+", ";
      if (a>0) Col++;
      
    }
     Console.Write($"{result} \b\b\b из них больше нуля {Col} чисел");
}
Task41();
void Task43()
{
Console.Clear();
Console.Write ("Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 *x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем\n");
    
    double b1 = InputDouble("Введите число b1: ");
    double k1 = InputDouble("Введите число k1: ");
    double b2 = InputDouble("Введите число b2: ");
    double k2 = InputDouble("Введите число k2: ");
    double X;
    double Y;
    X = Math.Round((b2-b1)/(k1-k2),2);
    Y=Math.Round(k1*X+b1,2);
    Console.Write("Точка пересечения двух прямых, заданных уравнениями y = k1 *x + b1, y = k2 * x + b2; случае,"+
                    $"когда \n b1 = {b1}\n k1 = {k1}\n b2 = {b2}\n k2 = {k2}\n"+
                     $"имеете коордиаты ({X}; {Y})");
}

Task43();


