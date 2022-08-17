Console.Clear();

int[] arr = new int[8]; // создали массив из восьми элементов

void RandomArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        //Создание объекта для генерации чисел
        Random rnd = new Random();
        //Получить случайное число 
        int value = rnd.Next(100);
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}

RandomArray(arr);