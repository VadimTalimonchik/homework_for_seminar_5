// Задача 38.
// Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CetArray(int size, int minValue, int maxValue)
{
    Random rand = new Random();
    double[] res = new double[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue) + Math.Round(rand.NextDouble(), 3);
    }
    return res;
}

void PrintArray(double[] arr)
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

double[] array = CetArray(a, b, c);
PrintArray(array);
Console.WriteLine();

double DifferenceMaxMin(double [] arr)
{
    int index = 0;
    double max = arr[0];
    double min = arr[0];
    double delta;
    while(index < arr.Length)
    {
        if(arr[index] > max)
        {
            max=arr[index]; 
        }
        if(arr[index] < min)
        {
            min=arr[index]; 
        }
        index++;
    }

    return delta = max - min;    
}

Console.WriteLine($"Разница между наибольшим значением и наименьшим значением массива равна {DifferenceMaxMin(array)}");
