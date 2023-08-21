namespace Project;
class Program
{
    static void Main(string[] args)
    {
        int Input (string text)
        {
            Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());

        }
      void Task10()
      {
       Console.WriteLine ("Задача 10: Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа");
       int num = Input("Ведите число "); // Используем метод созданный выше
       int s_num = (num/10)%10;
       Console.WriteLine($"Вторая цифра числа {num}: {s_num}");

      }
      Task10();
      
      void Task13()
      {
       Console.WriteLine ("Задача 13: Программа, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
       int num = Math.Abs(Input("Ведите число ")); // Используем метод созданный выше
       int col_num = (int)Math.Log10(num);
       int num_del = (int) Math.Pow(10,(col_num-2));
       if (num_del < 1) Console.WriteLine($"Третья цифра у числа {num} отсутсвует");
       else Console.WriteLine($"Третья цифра числа {num}: {num/num_del%10}");
      }
      Task13();

     void Task15()
     {
      Console.WriteLine ("Задача 15: Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным");
      int num = Input("Ведите цифру, обозначающую день недели "); // Используем метод созданный выше
        if (5<num && num<8) 
        {
         Console.WriteLine("да");
        }
        else if (0<num && num<6)
        {
         Console.WriteLine("нет");
        } 
        else
        {
         Console.WriteLine("Введенное число не обозначает день недели!");
        }
     }
    Task15();

      

}

}



