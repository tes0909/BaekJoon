int[,] array = new int[9, 9];
int max = int.MinValue;
int row = 0;
int col = 0;

for (int i = 0; i < 9; i++)
{
    string[] input = Console.ReadLine().Split();
    for (int j = 0; j < 9; j++)
    {
        array[i, j] = int.Parse(input[j]);
        if(array[i, j] > max)
        {
            max = array[i, j];
            row = i + 1;
            col = j + 1;
        }
    }
}
Console.WriteLine(max);
Console.WriteLine($"{row} {col}");