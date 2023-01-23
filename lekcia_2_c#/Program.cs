// int Max( int arg1, int arg2, int arg3)  
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result; 
// }                                       //выше код для определия максимума из 3х числел
// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 463;
// int b2 = 52;
// int c2 = 24;
// int a3 = 4746;
// int b3 = 59;
// int c3 = 95;

// int max1  = Max(a1,b1,c1);
// int max2  = Max(a2,b2,c2);
// int max3  = Max(a3,b3,c3);
// int max   =  Max(max1,max2,max3);

// Console.WriteLine (max);             //вывод максимума 
// _________________________________________________


// int Max( int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result; 
// }                                      
// int[] array = {15,24,3,34,1455,66,76,58,958};
// array [0]= 68;
//  int result = Max (
//      Max (array[0], array[1], array[2]),
//      Max (array[3], array[4], array[5]),
//      Max (array[6], array[7], array[8]));

// Console.WriteLine(result);
//______________________________________________________

// int [] array = {11,25,13,4,25,65,27,48};

// int n = array.Length;
// int find = 25;
// int index = 0;

// while (index < n )
// {
//     if(array[index ]== find)
//     {
//         Console.WriteLine(index);
//         break;

//     }  
//     index ++;
// }               // задача на поиск индекса заданного числа
// //__________________________________________________________________

void FillArray(int[] collection)  
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index ++;
    } 
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0; 
    while (position < count)
    {
          Console.WriteLine(col[position]);
          position++;    
    }
}


int IndexOf (int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;  // -1 значение для отсутствия числа

    while (index < count)
    {
        if(collection[index]== find)
        {
           position = index;
           break;             // остановить цикл после нахождения первого значения
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // длина массива

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);// поиск значения
Console.WriteLine(pos);