// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int GetSum(int A)

// {
//     int sum = 0;
//     for (int i = 1; i <= A; i++)
//     {
//         sum +=i;
//     }
// return sum;
// }
// Console.Write("Vvedite A =  ");
// int n = int.Parse(Console.ReadLine()!);
// int sum = GetSum(n);
// Console.WriteLine($" Symma chisel pavna {sum}");
// _____________________________________________________

// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5



/*
void main()

{
   Console.Clear();
Console.WriteLine("Vvedite 4islo =  ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine(result(num)); 
}

int result(int number)
{
    if(number<0) number *= -1;
    int count = 0; 
    while (number>0)
    {
        number /= 10;
        count++;
    }
    return count;
}

main(); 
 */


//  Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


/*
int Mult(int arg)
{
    int x = 1;
    for (int i = 1; i <= arg; i++)
    {
        x *= i;
    }
    return x;

}

Console.Write("Vvedite 4islo =  ");
int a = int.Parse(Console.ReadLine()!);
int total = Mult (a);
Console.WriteLine(total);
_________________________________________
*/

// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
 
 void main()
 {
    int[] intArray = new int [8];
    
    for (int i = 0; i < intArray.Length ; i++)
    {
        int randInd = new Random().Next(0,2);
        intArray[i] = randInd;
    }
    printArray(intArray);
 }

 void printArray(int[] array)

 {
    string outArray = "";
    for (int i = 0; i < array.Length; i++)
    {
        outArray += array[i];
        if (i != array.Length - 1 ) outArray += ", ";

    }
    Console.WriteLine(outArray);
 }
main();