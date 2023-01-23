/*Задача №18. Работа в группах
Напишите программу, которая по заданному номеру
четверти, показывает диапазон возможных координат
точек в этой четверти (x и y).*/



Console.Clear();
Console.Write("Введите четверть =  ");
int x = int.Parse(Console.ReadLine()!);


if (x == 1 )
{
    Console.WriteLine ("Координаты Y > 0, X > 0");
}
 else if (x == 2)
 {
    Console.WriteLine ("Координаты Y > 0, X < 0");
 }
 else if (x == 3 )
{
    Console.WriteLine ("Координаты Y < 0, X < 0");
    
}
else if (x == 4 )
{
    Console.WriteLine ("Координаты Y < 0, X > 0");
    
}
if (  1 > x || x > 4  )
{
    Console.WriteLine ("Такой четверти не существует");
}    