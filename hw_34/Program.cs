// Задача 34.
// Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArray()
{
    int[] array = new int[10];
    for(int i = 0; i < 10; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    Console.Write("[");

    for (int i = 0; i < 10 - 1; ++i)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[10 - 1] + "]");
    return array;
}

void FindNum(int[] Array)
{
int even = 0;
for(int i = 0; i <10; i++)
{
    if(Array[i] % 2 == 0) even++;
}
Console.WriteLine("->");
Console.WriteLine($"Количество чётных чисел в массиве: {even}.");
}

FindNum(CreateArray());
