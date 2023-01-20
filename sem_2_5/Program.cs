// на вход подаетс два числа, опраделить является ли одно число квадратом другого

Console.Write ("Введите первое число   ");
int num1 = int.Parse(Console.ReadLine()! ) ;
Console.Write ("Введите второе число    ");
int num2 = int.Parse(Console.ReadLine()! ) ;

if (num1*num1 == num2 || num2*num2 == num1 )
{
    Console.WriteLine ("da");   
}
else 
 Console.WriteLine ("net");