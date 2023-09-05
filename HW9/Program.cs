using System.Data;
using System.Globalization;
using System.Net.WebSockets;
using System.Text.RegularExpressions;
using MyLib; //для обращения к методам лежащим в namespace MyLib (позволяет не прописывать название  namespace при обращении к методу, будем укороченно указывать только класс)
 
 void Task68()
   {
      Console.Clear();
      Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n."); 
      int m = MyLibClass.Input("Введите число m: ");
      int n = MyLibClass.Input("Введите число n: ");
      int Akkerman(int m, int n) 
      {
        if (m==0) return n+1;
         else 
         {
           if (n==0) return Akkerman(m-1,1);
           else return Akkerman(m-1,Akkerman(m,n-1));
         }
      }  
     int result = Akkerman(m,n);
    Console.Write($"Значение функции Аккермана при m = {m} и n = {n} равно {result}");
   }
   Task68();



void Task66()
   {
      //Console.Clear();
      Console.WriteLine("\n");
      Console.WriteLine("Задача 66: Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов в промежутке от M до N."); 
      int M = MyLibClass.Input("Введите число M: ");
      int N = MyLibClass.Input("Введите число N: ");
      int Recursion(int M, int N,int summ=0) //summ - не обязательный параметр, не требующий ввода при запуске рекрсии, по умолчанию =0
      {
        if (M>N) // условие выхода из рекурсии
        {
          return summ;
        } 
        summ=summ+M;
        M++;
      return Recursion(M,N,summ); //повторный запуск рекурсии (автоматически как цикл, на следующий круг не запускается)
      }
     int summ = Recursion(M,N);
    Console.Write($"Сумма натуральных элементов в промежутке от {M} до {N} равна {summ}");
   }
  Task66();


void Task64()
   {
      //Console.Clear();
      Console.WriteLine("\n");
      Console.WriteLine("Задача 64:Задайте значения M и N. Напишите рекурсивный метод, который "
                             + "выведет все натуральные числа кратные 3-ём в промежутке от M до N."); 
      int col = MyLibClass.Input("Введите число M: ");
      int number = MyLibClass.Input("Введите число N: ");
      void Recursion(int col, int number)
      {
        if (col>number) return; // условие выхода из рекурсии
        if (col%3==0) Console.Write(col+" " );
        col++;
      Recursion(col,number); //повторный запуск рекурсии (автоматически как цикл, на следующий круг не запускается)
      }
     Recursion(col,number);  
   }

   Task64();