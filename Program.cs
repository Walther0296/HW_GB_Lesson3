Console.WriteLine("Домашнее задание №3. Базовые алгоритмы. Продолжение");
// // Задача 19
// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да
// Console.WriteLine("Задание №1");
// Console.Write("Введите пятизначное число а: ");
// int num = Convert.ToInt32 (Console.ReadLine ());
// boolean palindrom = false;
// if (10000>num || num>99999) {
//   Console.WriteLine("Число не пятизначное");  
// }
// else 
// {   for (i=0; i>5; i++)

// {for (i=0; i>5; i++)}
// Console.WriteLine("Число " + num + ": " + palindrom);
// }


// // Задача 21
// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// // A (3,6,8); B (2,1,-7), -> 15.84
// // A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Задание №2");
Console.WriteLine("Введите координаты точки А:");
Console.Write("X = ");
int X1 = Convert.ToInt32 (Console.ReadLine ());
Console.Write("Y = ");
int Y1 = Convert.ToInt32 (Console.ReadLine ());
Console.Write("Z = ");
int Z1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine("Введите координаты точки B:");
Console.Write("X = ");
int X2 = Convert.ToInt32 (Console.ReadLine ());
Console.Write("Y = ");
int Y2 = Convert.ToInt32 (Console.ReadLine ());
Console.Write("Z = ");
int Z2 = Convert.ToInt32 (Console.ReadLine ());

double length = Math. Sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2-Z1)^2);
Console.WriteLine("Расстояние между точками А И В равно " + length);
Console.WriteLine(String.Empty);



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Задание №3");
Console.Write("Введите число N: ");
int N = Convert.ToInt32 (Console.ReadLine ());
int a = 1; 
Console.Write("Кубы чисел от 1 до " + N + ": ");
for ( int i=0; i<N; i++){
    Console.Write(Math.Pow(a, 3) + " ");
     a++;
}
Console.WriteLine(String.Empty);