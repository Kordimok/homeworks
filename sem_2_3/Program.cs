// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления

Console.Clear ();

Console.WriteLine ("Введите первое число :  ");
int a =  int.Parse(Console.ReadLine () );

Console.WriteLine ("Введите второе число :  ");
int b = int.Parse(Console.ReadLine () );
int ost = a % b; 

if (ost != 0)
{
Console.WriteLine ($" Не кратно, остаток равен {ost} ");
}
else 
{
  Console.WriteLine ($"Kратно");  
}