// string Method4 (int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i< count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(5, "abcd");
// Console.WriteLine(res);
// ___________________________________________________-

// string Method4 (int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(5, "O");
// Console.WriteLine(res);
//___________________________________

// for (int i = 2; i <= 10 ; i++)
// {
//     for (int j = 2; j <=10; j++)
//     {
//        Console.WriteLine($" {i} x {j} = {i*j} "); 
//     }
//     Console.WriteLine();
// } 
// __________________________Таблица умножения


// — Я думаю, — сказал князь, улыбаясь, — что,
// ежели бы вас послали вместо нашего милого
// Винценгероде, вы бы взяли приступом согласие
// прусского короля. Вы так красноречивы. Вы
// дадите мне чаю?


// string text= " — Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали вместо нашего милого Винценгероде, вы бы взяли приступом согласие прусского короля. Вы так красноречивы. Выдадите мне чаю?";

// String Replace (string text, char oldValue, char newValue)
// {
//     string result = string.Empty;
//     int length = text.Length;

//     for (int i = 0; i < length; i++)
//     {
//             if (text[i] == oldValue) result = result + $"{newValue}";
//             else result = result + $"{text[i]}";
                
//     }
//     return result;
// }
// string newtext = Replace(text, ' ', '|' );

// Console.WriteLine(newtext);
// Console.WriteLine();

// newtext = Replace ( newtext, 'к', 'К');
// Console.WriteLine(newtext);
// Console.WriteLine();
// ___________________________________Замена символов в текте


// int [] arr = { 1, 3, 5, 3, 7, 3, 8, 9, 7}; 

// void PrintArray (int [] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]}");

//     }
//     Console.WriteLine();
// }
// void SelectionSort (int [] array )
// {
//         for (int i = 0; i < array.Length - 1 ; i++)
//         {
//             int minpos = i; 

            
//              for (int j = i + 1; j < array.Length; j++ )     
//             {  
//               if (array[j] < array[minpos]) minpos = j ;
              
                
              
//             }
              
//             int temp = array[i];
//             array[i] = array[minpos];
//             array[minpos] = temp;
//         }
// }

// PrintArray (arr);
// SelectionSort (arr);

// PrintArray (arr);
// ______________________Упорядочивание массива