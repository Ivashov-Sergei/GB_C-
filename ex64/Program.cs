Console.Clear();

Console.WriteLine("Введите число M: ");
int firstUserNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int secondUserNumber = Convert.ToInt32(Console.ReadLine());

string NumbersRec(int firstUserNumber, int secondUserNumber)
{
    if (firstUserNumber < secondUserNumber)
    {
        return $"{secondUserNumber} " + NumbersRec(firstUserNumber, secondUserNumber - 1);
    }
    else
    {
        return $"{firstUserNumber} ";
    }
}

Console.WriteLine(NumbersRec(firstUserNumber, secondUserNumber));