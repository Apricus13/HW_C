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

    /* void Task19()
      {
       Console.WriteLine ("Задача 19: Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом");
       int num = Input("Ведите число "); // Используем метод созданный выше
       while (num<10000 || num>99999)
      {
            num = Input("Введено не пятизначное число! Повторите ввод: ");
 
      }
       int n1 = num/10000;
       int n2 = (num/1000)%10;
       int n4 = (num/10)%10;
       int n5 = (num%10);
       if (n1 == n5 && n2 ==n4)
            Console.WriteLine($"Число {num} палиндром");
       else Console.WriteLine($"Число {num} не является палиндромом");

      }
      Task19();

void Task21()
{
    Console.WriteLine ("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
int Ax = Input("Введите координату Х точки  А:  "); // Используем метод созданный выше
int Ay = Input("Введите координату У точки  А:  ");
int Az = Input("Введите координату Z точки  А:  ");
int Bx = Input("Введите координату Х точки  В:  "); 
int By = Input("Введите координату У точки  В:  ");
int Bz = Input("Введите координату Z точки  В:  ");
int x = Math.Abs(Ax-Bx);
int y = Math.Abs(Ay-By);
int S = (int)Math.Sqrt((Ax-Bx)*(Ax-Bx) + (Ay-By)*(Ay-By));

 Console.WriteLine ($"Расстояние между точками А и В: {Math.Round(Math.Sqrt(Math.Pow((Ax-Bx),2) + Math.Pow((Ay-By),2)+Math.Pow((Az-Bz),2)),2)}");
 }
Console.Clear();
Task21();*/

void Task23()
{
  Console.WriteLine ("Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

int N = Input("Введите число:  "); // Используем метод созданный выше
while (N<1)
      {
        N = Input("Число должно быть больше 1! Повторите ввод: ");
 
      }
for (int a = 1;a <= N; a++)
   {
     Console.WriteLine($"{a}^3 = {(Math.Pow((a),3))}");
   }

 }
 
Console.Clear();
Task23();


   

}

}



