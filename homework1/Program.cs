// Задача 1: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.

// Задача 2: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.

// Задача 3: Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).

// Задача 4: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.

    //1.
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"Число {a} больше чем число {b}");
}
else 
{
    Console.WriteLine($"Число {b} больше чем число {a}");
}

   //2.
Console.WriteLine("Введите первое число: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (z > x)
{
    if (z > c) Console.WriteLine($"Число {z} максимальное");
    else Console.WriteLine($"Число {c} максимальное");
}
else 
{
    if (x>c) Console.WriteLine($"Число {x} максимальное");
}

    //3.
Console.WriteLine("Введите число: ");
int q = Convert.ToInt32(Console.ReadLine());
if (q % 2 == 0 )
{
     Console.WriteLine("Четное");
 }
 else 
 {
     Console.WriteLine("Нечетное");
 }

    //4.
Console.WriteLine("Введите число: ");
 int w = Convert.ToInt32(Console.ReadLine());

for(int i =2;i<=w;i+=2)
Console.WriteLine(i);