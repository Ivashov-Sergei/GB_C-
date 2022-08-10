Console.Clear();

Console.WriteLine("Введите число: ");
int threeDigitNum = Convert.ToInt32(Console.ReadLine());

if (threeDigitNum > 99 && threeDigitNum < 1000)
{
    Console.WriteLine((threeDigitNum / 10) % 10);
}
else
{
    Console.WriteLine("Введите другое число!");
}