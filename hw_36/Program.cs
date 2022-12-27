// Задача 36.
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

void PrintArray(int[] arr)
{
    Console.Write("Сгенерированный массив: ");
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

Console.Write("Введите размер массива: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное число массива: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное число массива: ");
int c = int.Parse(Console.ReadLine()!);

int[] array = CetArray(a, b, c);
PrintArray(array);
Console.WriteLine();

void FindSum(int[] ar)
{
int sum = 0;
for(int i = 0; i < array.Length; i++)
{
    if(i % 2 != 0) sum += array[i];
}
Console.WriteLine($"Сумма чисел стоящих на нечётных позициях в массиве равна: {sum}.");
}
FindSum(array);
