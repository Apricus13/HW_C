using System.Text.RegularExpressions;
using MyLib; //для обращения к методам лежащим в namespace MyLib (позволяет не прописывать название  namespace при обращении к методу, будем укороченно указывать только класс)
using System.Data;
using System.Globalization;
void Task58()
   {
      //Console.Clear();
      Console.WriteLine("Заполните спирально массив 4 на 4 числами от 1 до 16."); 
      int rows = 4; //колличество строк
      int colums = 4; // колличество столбцов
      int i=0;
      int j=0;
      int [,] matrix = new int[rows, colums];
      matrix[i,j] = 1;
      for (j++; j<colums; j++) // 1 шаг
      {
        matrix[i,j]=matrix[i,j-1]+1;
      }
      j--;
 
      for (i++; i<rows; i++) // 2 шаг
      { 
        matrix[i,j]=matrix[i-1,j]+1;
      }
      i--;
      for (j--; j>=0; j--) // 3 шаг
      {  
        matrix[i,j] = matrix[i,j+1]+1;
      }
      j++;
     for (i--; i>0; i--) // 4 шаг
      { 
        matrix[i,j] = matrix[i+1,j]+1;
      }
      i++;
      for (j++; j<colums-1; j++) // 5 шаг 13-14
      {
        matrix[i,j] = matrix[i,j-1]+1;
      }
      j--;
      for (i++; i<rows-1; i++) // 6 шаг 14-15
      {
        matrix[i,j] = matrix[i-1,j]+1;
      }
      i--;
      for (j--; j==1; j--)
      {
        matrix[i,j] = matrix[i,j+1]+1;
      }

      Console.WriteLine(); 
     MyLibClass.PrintArray(matrix);
   }
Task58();


void Task54()
   {
      //Console.Clear();
      Console.WriteLine("Задайте двумерный массив. Напишите программу, которая "
                         +"упорядочит по убыванию элементы каждой строки двумерного массива."); 
      int rows = 4; //колличество строк
      int colums = 4; // колличество столбцов
      int [,] matrix = new int[rows, colums];
      MyLibClass.FillArray(matrix,0,50);
      MyLibClass.PrintArray(matrix);
      Console.WriteLine(); 
      for (int i = 0;i<matrix.GetLength(0);i++)
        { 
          for (int col=0;col<matrix.GetLength(0);col++)
          {
            for (int j=0;j<matrix.GetLength(1)-1;j++)
              {  
                if (matrix[i,j]<matrix[i,j+1])
                {
                  int temp = matrix[i,j];
                  matrix[i,j]=matrix[i,j+1];
                  matrix[i,j+1] = temp;
                }
              }
          }  
        }
      Console.WriteLine(); 
      MyLibClass.PrintArray(matrix);
   }
Task54();
void Task56()
   {
      //Console.Clear();
      Console.WriteLine("Задайте прямоугольный двумерный массив. Напишите "
                         +"программу, которая будет находить строку с наименьшей суммой элементов. ."); 
      int rows =MyLibClass.Input("Задайте колличество строк в массиве: ");
      int colums = MyLibClass.Input("Задайте колличество столбцов в массиве отличное от строк: ");
      int Summ=0;
      int SummMin=0;
      int iMin=0;
      if (rows==colums) Console.WriteLine("Колличество строк не должно быть равно колличеству столбцов! Попробуйте, еще раз!");
      else {
             int [,] matrix = new int[rows, colums];
             MyLibClass.FillArray(matrix,0,5);
             MyLibClass.PrintArray(matrix);
             Console.WriteLine(); 
             for (int i = 0;i<matrix.GetLength(0);i++)
             {  
                Summ=0;
                for (int j=0;j<matrix.GetLength(1);j++)
                {  
                  Summ=Summ+matrix[i,j];
                }
                if (i==0|SummMin > Summ) 
                   {
                    SummMin = Summ;
                    iMin=i+1;
                   }
                
               }
             Console.WriteLine($"Минимальная сумма элементов равная {SummMin} находится в строке {iMin}");
           }
       Console.WriteLine(); 
    }
 Task56();