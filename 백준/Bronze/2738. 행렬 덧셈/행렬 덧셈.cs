int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int N = numbers[0];
int M = numbers[1];

int[,] result = new int[N, M];

for (int k = 0; k < 2; k++)
{
    for (int i = 0; i < N; i++)
    {
        int[] row = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        for (int j = 0; j < M; j++)
        {
            result[i, j] += row[j];
        }
    }
}

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        Console.Write(result[i, j] + " ");
    }
    Console.WriteLine();
}

