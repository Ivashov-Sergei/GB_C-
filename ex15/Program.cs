Console.Clear();

Console.WriteLine("Введите день недели: ");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());

if (dayOfWeek > 0 && dayOfWeek < 8)
{
    if (dayOfWeek > 5 && dayOfWeek < 8)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Введите число от 1 до 7!");
}
