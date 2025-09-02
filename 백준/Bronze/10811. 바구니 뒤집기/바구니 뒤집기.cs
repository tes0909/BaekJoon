string[] input = Console.ReadLine().Split();
int N = int.Parse(input[0]);
int M = int.Parse(input[1]);

int[] basket = new int[N + 1];

for(int x = 1; x <= N; x++)
{
    basket[x] = x;
}

for(int x = 0; x < M; x++)
{
    string[] s = Console.ReadLine().Split();
    int i = int.Parse(s[0]);
    int j = int.Parse(s[1]);
    Array.Reverse(basket, i, j - i + 1);
}

for (int x = 1; x <= N; x++)
{
    Console.Write(basket[x] + " ");
}