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

RandomArray(arr);

void GetOddSum(int[] array)
{
    int oddSum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        oddSum += arr[i];
    }
    Console.WriteLine($"Сумма элементов с нечетным индексом равна: {oddSum}");
}

GetOddSum(arr);