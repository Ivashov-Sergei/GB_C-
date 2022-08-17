Console.Clear();

Console.WriteLine("Введите минимум пятизначное число N: ");
int nNumber = Convert.ToInt32(Console.ReadLine());

int temp = nNumber;
int rev = 0;

if (nNumber > 2)
{

    while (nNumber > 0)
    {
        int dig = nNumber % 10;
        rev = rev * 10 + dig;
        nNumber = nNumber / 10;
    }
    if (temp == rev)
    {
        Console.WriteLine("Это палиндром!");
    }
    else
    {
        Console.WriteLine("Это не палиндром!");
    }
}
else
{
    Console.WriteLine("Введите число больше 2 символов!");
}