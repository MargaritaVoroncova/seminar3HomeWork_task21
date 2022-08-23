//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 
//3D пространстве.

Console.WriteLine("Введите координату x первой точки: ");
int userX1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y первой точки: ");
int userY1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату z первой точки: ");
int userZ1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x второй точки: ");
int userX2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y второй точки: ");
int userY2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату z второй точки: ");
int userZ2 = Convert.ToInt32(Console.ReadLine());

double segment = Math.Sqrt((userZ2 - userZ1) * (userZ2 - userZ1) + (userY2 - userY1) * (userY2 - userY1) + (userX2 - userX1) * (userX2 - userX1));
segment = Math.Round(segment, 2);
Console.WriteLine($"Расстояние между точками равно: {segment}");

