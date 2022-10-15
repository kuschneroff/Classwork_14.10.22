/*
Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых в отрезке [10, 99].
Пример для массива из 5, а не 123 элементов. В своем примере сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int [] RandomArray()
{
int [] array = new int [10];
Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(-100, 100);
        return array;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int GetNumberOfRange(int [] array)
{   
    int resultRange = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 99)
        resultRange++;
    }
    return resultRange;
}
int [] arr = RandomArray();
PrintArray(arr);
Console.WriteLine();
int count = GetNumberOfRange(arr);
Console.WriteLine($"Значение в диапозоне [10, 99] - {count} штук...");