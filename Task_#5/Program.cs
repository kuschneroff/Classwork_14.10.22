/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элементы. второй и предпоследний элементы и т.д.
Результат запишите в новом массиве.
*/

int [] RandomArray(int arraySize)
{
    int [] array = new int [arraySize];
    Random rnd = new Random();
    for (int i = 0; i < arraySize; i++)
    {
        array[i] = rnd.Next(1, 10);
    }
    return array;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] product(int[] array)
{   
    int NewArrayLength = array.Length / 2; // действие которое позволяет делить массив на двое 
    if(array.Length % 2 != 0)
    NewArrayLength = NewArrayLength + 1;

    int [] resultProd = new int [NewArrayLength]; 
    for (int i = 0; i < NewArrayLength; i++)
        resultProd[i] = array[i] * array[array.Length - i - 1];

    if(array.Length % 2 != 0)
    resultProd[NewArrayLength - 1] = array[NewArrayLength - 1];
    
    return resultProd;
}
Console.WriteLine($"Введите, пожалуйста, размер масссива");
int arraySize = int.Parse(Console.ReadLine() ??"");
int[] arr = RandomArray (arraySize);
PrintArray(arr);
int[] resultProduct = product(arr);
PrintArray(resultProduct);