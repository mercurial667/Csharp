// See https://aka.ms/new-console-template for more information

// byte bt = 125;    //2^8
// int i = 5;   //2^32
// double d = 5.5;  //2^64
// string s = "lol";
// bool b = false;

// int a = 4;
// int x = 2022;
// double i2 = a/x;
// byte bt1 = (byte)x;
// int x1 = bt;
// Console.Writeline(x1);

//0. Демонстрация решения
// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

//  Console.Write("Введите целое число: ");
//  int num = Convert.ToInt32(Console.ReadLine());
// // int num = 4;
//  int square = num * num;
//  Console.WriteLine($"Квадрат числа {num} = {square}");

// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 5; b = 25 -> да
// a = 2 b = 10 -> нет
// a = 9; b = -3 -> нет
// a = -3 b = 9 -> да
// 2. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// 1.
// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 == num2 * num2)
// {
// Console.WriteLine("yes");
// }
// else 
// {
// Console.WriteLine("no");
// }

//2.
// Console.WriteLine("Введите номер дня недели: ");
// int numb = Convert.ToInt32(Console.ReadLine());
// if(numb > 0&& numb < 8)
// {
//     if(numb == 1) Console.WriteLine("Понедельник");
//     if(numb == 2) Console.WriteLine("Вторник");
//     if(numb == 3) Console.WriteLine("Среда");
//     if(numb == 4) Console.WriteLine("Четверг");
//     if(numb == 5) Console.WriteLine("Пятница");
//     if(numb == 6) Console.WriteLine("Суббота");
//     if(numb == 7) Console.WriteLine("Воскресенье");
// }
// else
// {
//     Console.WriteLine("Дурак?");
// }



// 3. Напишите программу вычисления функции:
//  x = f(a)
// 4. Напишите программу, которая на вход принимает одно число
// (N), а на выходе показывает все целые числа в промежутке от -N
// до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

//3.
