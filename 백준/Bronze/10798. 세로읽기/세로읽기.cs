char[,] matrix = new char[5, 15];

for (int i = 0; i < 5; i++)
{
    string input = Console.ReadLine();
    for(int j = 0; j < input.Length; j++)
    {
        matrix[i, j] = input[j];
    }
}

for (int j = 0; j < 15; j++)
{
    for (int i = 0; i < 5; i++)
    {
        if(matrix[i, j] != '\0')
        {
            Console.Write(matrix[i, j]);
        }
    }
}