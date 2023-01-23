/*Задача №22. Работа в группах
Напишите программу, которая принимает на вход
число (N) и выдаёт таблицу квадратов чисел
от 1 до N.
● 5 -> 1, 4, 9, 16, 25.
● 2 -> 1,4  */

Console.Clear();
Console.Write("Введите любое число  ");
double num = int.Parse(Console.ReadLine());    

int count = 1;
Console.Write($"{Math.Pow(count,2)}");
count++;
while (count <= num)
{
    double result = Math.Pow(count, 2);
    Console.Write($", {result}" );
    count++;
}