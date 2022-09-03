Console.Clear();

Console.WriteLine("Введите число M: ");
int firstUserNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int secondUserNumber = Convert.ToInt32(Console.ReadLine());

if (firstUserNumber % 2 != 0)
{
    firstUserNumber++;
}

int NumbersRec(int firstUserNumber, int secondUserNumber)
{
    if (firstUserNumber <= secondUserNumber)
    {
        return firstUserNumber + NumbersRec(firstUserNumber + 2, secondUserNumber);
    }
    else
    {
        return 0;
    }
}

Console.WriteLine(NumbersRec(firstUserNumber, secondUserNumber));