using System.Text.RegularExpressions;
namespace MyLib
{
  public static class MyLibClass
  {
     public static int Input(string text)   //метод приема данных с преобразованием в int
      {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
      }
    
     public static double InputDouble(string text)   //метод приема данных с преобразованием в int
     {
        Console.Write(text);
        return Convert.ToDouble(Console.ReadLine());
     }

     public static void FillArray(int [] array, int minValue = -9, int maxValue =9) //метод заполнения массива, введенные значения параметров minValue и  maxValue позволяют делать эти параметры не                                                              //обязательными к заполнению
     { 
        maxValue++; //т.к. верхняя граница не включается
        Random rnd = new Random(); // вызов конструктора для заполнения рондомными числами
        for (int i = 0; i < array.Length; i++) // заполняем массив  numbers.Length - размер массива
        {
          array[i] = rnd.Next(minValue, maxValue); //верхняя граница не включается
        }
     }
     public static void FillArray(double [] array, int minValue = -9, int maxValue =9) //метод заполнения массива для веществ, 
                                                               //введенные значения параметров minValue и  maxValue позволяют делать эти параметры не 
                                                                //обязательными к заполнению
     { 
       maxValue++; //т.к. верхняя граница не включается
       Random rnd = new Random(); // вызов конструктора для заполнения рондомными числами
       for (int i = 0; i < array.Length; i++) // заполняем массив  numbers.Length - размер массива
        {
         array[i] = rnd.NextDouble()*(maxValue-minValue)+minValue;//верхняя граница не включается rnd.NextDouble() - выводит значения от 0 до 1, для увеличения диапазана приведены след ариф действия
         array[i] = Math.Round(array[i],2); // округляем до 2 чисел после запятой
        }
     }
     public static void FillArray(int [,] matrix, int minValue = -9, int maxValue =9) //метод заполнения двумерного массива для целых чисел, 
                                                               //введенные значения параметров minValue и  maxValue позволяют делать эти параметры не 
                                                                //обязательными к заполнению
    {   maxValue++; //т.к. верхняя граница не включается
        Random random = new Random();
        for (int i = 0; i<matrix.GetLength(0); i++) //matrix.GetLength : 0 - длина (колличество) строк, 1 - длина (колличество) столбцов
          { 
           for (int j = 0; j<matrix.GetLength(1); j++)
           matrix[i,j] = random.Next(minValue, maxValue);
          }
    }
     public static void FillArray(double [,] matrix, int minValue = -9, int maxValue =9) //метод заполнения двумерного массива для целых чисел, 
                                                               //введенные значения параметров minValue и  maxValue позволяют делать эти параметры не 
                                                                //обязательными к заполнению
    {   maxValue++; //т.к. верхняя граница не включается
        Random random = new Random();
        for (int i = 0; i<matrix.GetLength(0); i++) //matrix.GetLength : 0 - длина (колличество) строк, 1 - длина (колличество) столбцов
          { 
           for (int j = 0; j<matrix.GetLength(1); j++)
              { 
                matrix[i,j] = random.NextDouble()*(maxValue-minValue)+minValue;//верхняя граница не включается rnd.NextDouble() - выводит значения от 0 до 1, для увеличения диапазана приведены след ариф действия
                matrix[i,j] = Math.Round(matrix[i,j],1); //округляем до одного знака после запятой
              }
          }
    }

     public static void PrintArray(int[] array) //метод вывода массива для типа int
     {
       for (int i = 0; i < array.Length; i++) // заполняем массив  numbers.Length - размер массива  
    {
        Console.Write($"{array[i]} ");
    }
       Console.WriteLine();
     }
     public static void PrintArray(double[] array) //метод вывода массива для веществ чисел

     {
      for (int i = 0; i < array.Length; i++) // заполняем массив  numbers.Length - размер массива  
      {
        Console.Write($"{array[i]} ");
      }
      Console.WriteLine();
     }
     public static void PrintArray(int[,] matrix) //метод вывода массива для типа int
     { 
         for (int i = 0; i<matrix.GetLength(0); i++) //matrix.GetLength : 0 - длина (колличество) строк, 1 - длина (колличество) столбцов
        { 
           for (int j = 0; j<matrix.GetLength(1); j++)
             { 
                Console.Write($"{matrix[i,j]}\t"); // \t - знак табуляции, позволяет относительно ровно выводить значения столбцов друг под другом
             }
           Console.WriteLine();
        }


     }
     public static void PrintArray(double[,] matrix) //метод вывода массива для типа int
     { 
         for (int i = 0; i<matrix.GetLength(0); i++) //matrix.GetLength : 0 - длина (колличество) строк, 1 - длина (колличество) столбцов
        { 
           for (int j = 0; j<matrix.GetLength(1); j++)
             { 
                Console.Write($"{matrix[i,j]}\t"); // \t - знак табуляции, позволяет относительно ровно выводить значения столбцов друг под другом
             }
           Console.WriteLine();
        }


     }

  }
}  
