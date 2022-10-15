/*
Задача 33: Задайте массив. напишите программу, 
которая опредедяет присутствует ли заданное число в массиве 
*/


    void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите число для сравнения");
int numberX = int.Parse(Console.ReadLine() ??"");

int [] RandomNum ()
{
int [] ResultArray = new int [10];
Random rnd = new Random();
for (int i = 0; i < ResultArray.Length; i++)
{
    ResultArray [i] = rnd.Next(-10, 10);
}
return ResultArray;
}

void Compare(int [] array, int numberX)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == numberX)
        {
            Console.WriteLine($"Введенное число {numberX} есть в массиве");
            return;
        }
    }
    Console.WriteLine("Такого числа нет");
}

int[] arr = RandomNum();
PrintArray(arr);
Compare(arr, numberX);