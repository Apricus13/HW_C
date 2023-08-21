void Task2() 
{
Console.WriteLine("Задача 2:Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее");
Console.WriteLine ("Введите первое число");
int f_num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число, отличное от первого");
int s_num = Convert.ToInt32(Console.ReadLine());
if (f_num>s_num)
{
   Console.WriteLine("Число " + f_num + " большее, а " + s_num + " меньшее"); 
}
else if (f_num<s_num)
{
   Console.WriteLine("Число " + s_num + " большее, а " + f_num + " меньшее"); 
}
else {
   Console.WriteLine("Числа равны"); 
}
}
Task2();
/*
void Task4() 
{
Console.WriteLine("Задача 4:Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел");
Console.WriteLine("Введите первое число");
int f_num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число, отличное от первого");
int s_num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите трете число, отличное от двух ранее введенных");
int t_num = Convert.ToInt32(Console.ReadLine());
if (f_num>s_num & f_num>t_num)
{
   Console.WriteLine ("Число " + f_num + " максимальное"); 
}
else if (s_num>t_num)
{
   Console.WriteLine ("Число " + s_num + " максимальное"); 
}
else {
   Console.WriteLine("Число " + t_num + " максимальное"); 
}

}
Task4();

void Task6()
{
Console.WriteLine("Задача 6:Программа, которая на вход принимает число и выдаёт, является ли число чётным или нет");
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num%2==0)
{
    Console.WriteLine("Число " + num + " - четное"); 
}
else
{
    Console.WriteLine("Число " + num + " - нечетное"); 
}
}
Task6();
void Task8()
{
Console.WriteLine ("Задача 8: Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N");
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
while (N<=1)
{
    Console.WriteLine("Число должно быть больше 1!Введите число снова.");
    N = Convert.ToInt32(Console.ReadLine());
}
int a = 2;
while (N>=a)
{
    Console.Write(a + " ");
   a=a+2;
}
}
Task8();

