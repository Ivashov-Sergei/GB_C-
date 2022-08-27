Console.Clear();

int[] arr = new int[20]; // создали массив из восьми элементов

void RandomArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        //Создание объекта для генерации чисел
        Random rnd = new Random();
        //Получить случайное число 
        int value = rnd.Next(100, 1000);
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}

void GetEven(int[] array)
{
    int evenNum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            evenNum++;
        }
    }
    Console.WriteLine($"Четных чисел в массиве - {evenNum}");
}

RandomArray(arr);
GetEven(arr);