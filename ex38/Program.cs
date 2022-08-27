Console.Clear();

int[] arr = new int[5]; // создали массив из восьми элементов

void RandomArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        //Создание объекта для генерации чисел
        Random rnd = new Random();
        //Получить случайное число 
        int value = rnd.Next(-100, 100);
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}

void GetDiffMaxMinNum(int[] array)
{
    int minNum = arr[0];
    int maxNum = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (minNum > arr[i]) minNum = arr[i];
        if (maxNum < arr[i]) maxNum = arr[i];
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементом равны: {maxNum - minNum}");
}

RandomArray(arr);
GetDiffMaxMinNum(arr);