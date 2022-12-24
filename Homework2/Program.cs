// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Сейчас мы будем узнавать какое из трех чисел больше, введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max=a;

if(a>=max) max=a;
Console.Write(a);

if(b>=a) max=b;
Console.Write(b);

if(c>=a) max=c;
Console.Write(c);

Console.Write("max= ");
Console.WriteLine(max);
