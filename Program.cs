Console.WriteLine("Домашнее задание №3. Базовые алгоритмы. Продолжение");

// // Задача 19
// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да
Console.WriteLine("Задание №1");
Console.Write("Введите пятизначное число а: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 0;
int devide = 0;
int devide1 = 0;
int index = 0;
if (10000 > num || num > 99999)
    Console.WriteLine("Число не пятизначное");
else
{
    for (int i = 0; i < 5; i++)
    {
        devide = Convert.ToInt32(Math.Pow(10, (4 - index)));
        devide1 = Convert.ToInt32(Math.Pow(10, index));
        if (index < 5)
            num1 = num1 + (((num / devide) % 10) * devide1);
        index++;
    }
}

if (num == num1)
    Console.WriteLine("Число " + num + " является палиндромом");
else
    Console.WriteLine("Число " + num + " не является палиндромом");
Console.WriteLine("Задача решена!");

Console.WriteLine(String.Empty);

// // Задача 21
// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// // A (3,6,8); B (2,1,-7), -> 15.84
// // A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Задание №2");
Console.WriteLine("Введите координаты точки А:");
Console.Write("X = ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y = ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z = ");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B:");
Console.Write("X = ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y = ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z = ");
int Z2 = Convert.ToInt32(Console.ReadLine());

double length = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2) + Math.Pow((Z2 - Z1), 2));
Console.WriteLine("Расстояние между точками А И В равно " + Math.Round(length, 2));
Console.WriteLine(String.Empty);

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Задание №3");
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;
Console.Write("Кубы чисел от 1 до " + N + ": ");
for (int i = 0; i < N; i++)
{
    Console.Write(Math.Pow(a, 3) + " ");
    a++;
}
Console.WriteLine(String.Empty);
