Console.Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int getSumOfNumbers(int number)
{
    int totalNum = 0;
    while (num > 0)
    {
        totalNum = totalNum + num % 10;
        num = num / 10;
    }
    return totalNum;
}

Console.WriteLine($"Сумма чисел в числе: {getSumOfNumbers(num)}");