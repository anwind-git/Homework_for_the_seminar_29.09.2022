// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.

void Task36()
{
    int[] array = new int[5];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(-100, 100);
    string arr = string.Join(", ", array);
    PrintAmount(array, arr);
}

void PrintAmount(int[] array, string arr)
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 > 0)
        {
            amount += array[i];
        }
    }
    Console.WriteLine($"Массив чисел: [" + arr + "]");
    Console.WriteLine($"Сумма элементов с нечётными индексами: " + amount);
}
Task36();