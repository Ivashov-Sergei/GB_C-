Console.Clear();

Console.WriteLine("Введите первое число: ");
int numOne = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numTwo = int.Parse(Console.ReadLine());

int getRate(int numberOne, int numberTwo)
{
    int totalNum = numOne;
    for (int i = 1; i < numTwo; i++)
    {
        totalNum *= numOne;
    }
    return totalNum;
}

Console.WriteLine($"Результат = {getRate(numOne, numTwo)}");