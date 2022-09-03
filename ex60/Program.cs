Console.Clear();

int[,,] treeDimensionalArray = new int[2, 2, 2];

treeDimensionalArray = GetTreeDimensionalArray(treeDimensionalArray);
PrintTreeDimensionalArray(treeDimensionalArray);


int[,,] GetTreeDimensionalArray(int[,,] array)
{
    int sum = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = sum;
                sum = sum + array[i, j, k];
            }
        }
    }
    return array;
}


void PrintTreeDimensionalArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}