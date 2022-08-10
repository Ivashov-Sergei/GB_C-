Console.Clear();

Console.WriteLine("Введите число: ");
int randomNumber = Convert.ToInt32(Console.ReadLine());

if (randomNumber > 99)
{
    while (randomNumber > 999)
    {
        randomNumber = randomNumber / 10;
    }
    Console.WriteLine(randomNumber % 10);
}
else
{
    Console.WriteLine("Третьей цифры нет!");
}
