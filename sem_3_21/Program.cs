/*Задача №21. Работа в группах
Напишите программу, которая принимает на вход
координаты двух точек и находит расстояние между
ними в 2D пространстве.
● A (3,6); B (2,1) -> 5,09
● A (7,-5); B (1,-1) -> 7,21*/

Console.Clear();
Console.Write("Введите координату х  =  ");
double x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y  =  ");
double y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату х  =  ");
double x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y  =  ");
double y2 = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt((Math.Pow((x1 - x2), 2 ) + Math.Pow((y1 - y2), 2)));
//result = Math.Round(result, 2);  //округление результата 
Console.WriteLine($"Расстояние между заданными точками {result:f3}"); // f3 округление значения результата