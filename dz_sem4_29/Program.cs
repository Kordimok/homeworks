// Задача 29: Напишите программу, которая задаёт массив из 8  элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

//Вероятнее всего в условии задачи допущена ошибка. 


// Возможное правильное условие задачи. 

//  Напишите программу, которая задаёт массив из N  элементов и выводит их на экран.

//5 -> [1, 2, 5, 7, 19]

//3 -> [6, 1, 33]


int lengArray = ReadInt("Длинна массива = ");

int[] randArray = new int[lengArray];
for (int i = 0; i < randArray.Length; i++)
{
    randArray[i] = new Random().Next(1 ,100);
    Console.Write(randArray[i] + " ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

