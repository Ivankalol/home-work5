//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return newArray;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write (array[i] + " ");
//     }
//     Console.WriteLine ();
// }


// int EvenNumber (int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i]%2==0)
//         {
//             sum++;
//         }
//     }
//     return sum;
// }

// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal three - digit value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal three - digit value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size, minValue, maxValue);
// Console.WriteLine();
// Console.WriteLine($"Random array: ");
// ShowArray(array);
// Console.WriteLine();
// Console.WriteLine($"Number of even numbers in the array -> {EvenNumber(array)}");




//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return newArray;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write (array[i] + " ");
//     }
//     Console.WriteLine ();
// }

// int SumOddPositions (int[] array)
// {
//     int sum = 0;
//     for(int i = 1; i < array.Length; i = i+2)
//     {
//         sum += array[i];
//     }
//     return sum;
// }

// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size, minValue, maxValue);
// Console.WriteLine();
// Console.WriteLine($"Random array: ");
// ShowArray(array);
// Console.WriteLine();
// Console.WriteLine($"Sum of odd positions-> {SumOddPositions (array)}");




// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] CreateRandomArray (int size, int minValue, int maxValue)
{
    double[] newArray = new double[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = Math.Round(new Random().Next(minValue, maxValue+1)+ new Random().NextDouble(),4);
        
    }
    return newArray;
}

void ShowArray (double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i] +  "  ");
    }
    Console.WriteLine ();
}

double MaximalMinimal (double[] array)
{
    double maxnum = array[0];
    double minnum = array[0];
    int i = 1;
    while(i < array.Length )
    {

        if (maxnum < array[i])
        {
            maxnum = array[i];
        }
        if (minnum > array[i])
        {
            minnum = array[i];
        } 
        i++;
    }
    return maxnum - minnum;
}


Console.WriteLine ("Input array size:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input minimal value of array element:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input maximal value of array element:");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[] array = CreateRandomArray(size, minValue, maxValue);
Console.WriteLine();
Console.WriteLine($"Random array: ");
ShowArray(array);
Console.WriteLine();
Console.WriteLine($"The difference between the maximum and minimum value -> {MaximalMinimal (array)}");
