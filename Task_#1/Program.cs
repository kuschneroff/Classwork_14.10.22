/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутков [-9, 9].
Найдите сумму отрицательные и положительеные элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
*/

int [] InitArray (int length) // инициализация массива рандомные числа от -9 до 9 длиной length
{
    int [] resultArray = new int [length];
    Random rnd = new Random();
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rnd.Next(-9, 10);
    }
    return resultArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int GetNumber(string message) // получение числа с консоли
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine() ??"");
    return result;
}

int GetSummOfPositive(int [] array) // получение суммы положительных чисел в массиве
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            summ += array[i];
    }
    return summ;
}

int GetSummOfNegative(int [] array) // получение суммы отрицательных чисел в массиве
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            summ += array[i];
    }
    return summ;
}
// первое значение это положительная сумма, второе значение это отрицательная сумма
(int, int) GetSumms(int [] array) // В целом это решение через кортежи в качестве втрого вариант решения 
{                                 // втрого вариант решения задачи, этот вариант решения гораздо 
    int positiveSumm = 0;         // оптимальнее, чем предыдущий, так как в предыдущим прогонется два прогона.
    int negativeSumm = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            negativeSumm += array[i];
        else
            positiveSumm += array[i];

    }
    return (positiveSumm, negativeSumm);
}

int length = GetNumber("Введите размерность массива");
int[] arr = InitArray(length);
PrintArray(arr);

int positiveSumm = GetSummOfPositive(arr);
int negativeSumm = GetSummOfNegative(arr);

(int pos, int neg) = GetSumms(arr);

Console.WriteLine($"Сумма положительных {positiveSumm} и Сумма отрицательных {negativeSumm}");
Console.WriteLine($"Сумма положительных {pos} и Сумма отрицательных {neg}");