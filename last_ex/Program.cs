Console.Clear();

string[] array = { "123", "324", "", "help" };
int lengthStringArray = GetLengthStringArray(array);

string[] newArray = SortStringArray(array, lengthStringArray);

PrintStringArray(array);
PrintStringArray(newArray, "Red");

int GetLengthStringArray(string[] array)
{
    int length = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length == 0) continue;
        else length++;
    }
    return length;
}

string[] SortStringArray(string[] array, int length)
{
    string[] newArray = new string[length];
    int index = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length == 0) continue;
        else
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;
}

void PrintStringArray(string[] array, string colorName = "Green")
{
    Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorName);
    Console.Write("[ ");

    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write($"'{array[i]}' ");
        else Console.Write($"'{array[i]}', ");
    }

    Console.WriteLine("]");
    Console.ResetColor();
}