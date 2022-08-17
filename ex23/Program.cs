Console.Clear();

Console.WriteLine("Введите число N: ");
int nNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= nNumber; i++)
{
    Console.Write($" {i * i * i} ");
}