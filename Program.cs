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


void Task25()
    {
      Console.WriteLine ("Используя определение степени числа,напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B");
      int A = Input("Введите число A ");
      int B = Input("Введите число B "); //степень числа
      int P =1;
      for (int i = 1;i<=B; i++)
          {Console.Write($"{A} * ");
            P*=A;
         }
      Console.Write ("\b\b= "); // \b-сдвиг каретки на 1 шаг
      Console.Write(P);
    }
Task25();

void Task27()
    {
     Console.WriteLine (" Задача 27: напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе");
      int A = Input("Введите число ");
      int B = A;
      int Sum = 0;
      int n; // значение цифры в числе
      while (A>0)
        {
        n=A%10;
        Console.Write($"{n} + ");
        A=A/10;
        Sum=Sum+n;
        }
    
      Console.Write ("\b\b= "); // \b-сдвиг каретки на 1 шаг
      Console.Write(Sum);
    }

Task27();

void Task29()
    {
      Console.WriteLine (" Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.");  
      int size = 8; // указываем размер будущего массива
      Random rnd = new Random(); // вызов конструктора для заполнения рондомными числами
      int[]numbers= new int [size]; //[] - обозначаем массив, начальный индекс массива =0
      for (int i=0;i<size; i++) // заполняем массив
      {
            numbers[i]=rnd.Next(-20,20); //верхняя граница не включается
      }
      
      for (int i=0;i<size-1; i++)
      {
            for (int a=0; a<size-i-1;a++)
            {
               if (Math.Abs(numbers[a])>Math.Abs(numbers[a+1]))
               {
                  int temp = numbers[a];
                  numbers[a] = numbers[a+1];
                  numbers[a+1] = temp;
               }

            }
            
      }   
        for (int i=0;i<size; i++)
      {
            Console.Write($"{numbers[i]} ");
      }
      }
Task29();

    
}
}