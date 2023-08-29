using System.Text.RegularExpressions;
using MyLib; //для обращения к методам лежащим в namespace MyLib (позволяет не прописывать название  namespace при обращении к методу, будем укороченно указывать только класс)
void Task47()
   {
      Console.Clear();
      Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n,заполненный случайными вещественными числами,округлёнными до одного знака.");
      int rows = 3; //колличество строк
      int colums = 4; // колличество столбцов
      double [,] matrix = new double[rows, colums];
      MyLibClass.FillArray(matrix,-3,20);  //новый метод описан в MyLib
      MyLibClass.PrintArray(matrix);      //новый метод описан в MyLib
   }
 // Task47();

void Task50()
   {
      Console.Clear();
      Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
      int rows = 3; //колличество строк
      int colums = 4; // колличество столбцов
      int [,] matrix = new int[rows, colums];
      MyLibClass.FillArray(matrix,-3,20);  
      MyLibClass.PrintArray(matrix);      

      int i = MyLibClass.Input("Введите индекс строки: ");
      int j = MyLibClass.Input("Введите индекс столбца: ");
      if (0<=i&&i<rows&&0<=j&&j<colums) Console.Write($"{matrix[i,j]}");
      else Console.Write("Элемент не существует");
   }
 // Task50();

void Task52()
   {
      Console.Clear();
      Console.WriteLine("Задача 52: Задайте двумерный массив из целых чисел.Найдите среднее арифметическое элементов в каждом столбце.");
      int rows = 3; //колличество строк
      int colums = 4; // колличество столбцов
      int [,] matrix = new int[rows, colums];
      double Sum=0;
      double A=0;
      MyLibClass.FillArray(matrix,-3,20);  
      MyLibClass.PrintArray(matrix);
      Console.WriteLine("Среднее арифметическое каждого столбца: ");

      for (int j = 0; j<matrix.GetLength(1); j++) //matrix.GetLength : 0 - длина (колличество) строк, 1 - длина (колличество) столбцов
          { 
           for (int i = 0; i<matrix.GetLength(0); i++)
              { 
                Sum=Sum+matrix[i,j];
              }
              A=Math.Round(Sum/matrix.GetLength(0),1);
              Console.Write($"{A}\t  ");
              Sum=0;
          }      
   }
  Task52();