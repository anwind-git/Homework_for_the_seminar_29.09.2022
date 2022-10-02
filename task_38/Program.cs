// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void Task38()
{
    double[] array = new double[5];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(random.NextDouble() * 200 - 100, 2);
    string arr = string.Join(", ", array);
    PrintAmount(array, arr);
}


void PrintAmount(double[] array, string arr)
{
    int i = 0;
    double max = array[i];
    double min = array[i];
    double sum = 0;
    while(i < array.Length)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        if(array[i] < min)
        {
            min = array[i];
        }
        i++;
    }

    sum = max - Math.Abs(min);
    Console.WriteLine();
    Console.WriteLine($"Массив чисел: [" + arr + "]");
    Console.WriteLine($"Максимальное число массива: " + max + " Минимальное: " + min);
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива: " + sum);
    Console.WriteLine();
}
Task38();