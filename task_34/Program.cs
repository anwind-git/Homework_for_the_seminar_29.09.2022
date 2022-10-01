// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
void Task34()
{
    int[] array = new int[5];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(100, 1000);
    string arr = string.Join(", ", array);
    PrintNumber(array, arr);
}

void PrintNumber(int[] array, string arr)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int number = array[i];
        if(number % 2 == 0)
        {
            quantity += 1;
        }
    }
    Console.WriteLine($"Массив чисел: [" + arr + "]");
    Console.WriteLine($"Количество чётных чисел в массиве: " + quantity);
}
Task34();

