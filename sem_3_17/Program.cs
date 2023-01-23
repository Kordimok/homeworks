/*Задача №17. Напишите программу, которая
принимает на вход координаты точки (X и Y),
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти
плоскости, в которой находится эта точка.*/

Console.Clear();
Console.Write("Введите x =  ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите y =  ");
int y = int.Parse(Console.ReadLine()!);

if (y > 0 )
{
    if (x > 0)
    {
        Console.WriteLine (" Первая четверть");
    }
    else
    { 
        Console.WriteLine ("Вторая четверть");
    }
}
else 
{
    if (x > 0)
    {
    Console.WriteLine ("Четвертая четверть");
    }       
    else
    {
    Console. WriteLine ("Третья четверть");
    }
}

