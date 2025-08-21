string[] input = Console.ReadLine().Split(' ');
int N = int.Parse(input[0]);
int M = int.Parse(input[1]);

int[] basket = new int[N + 1]; 

for (int m = 0; m < M; m++)
{
    string[] method = Console.ReadLine().Split(' ');
    int i = int.Parse(method[0]);
    int j = int.Parse(method[1]);
    int k = int.Parse(method[2]);
    
    for (int x = i; x <= j; x++)
    {
        basket[x] = k;
    }
}
for (int x = 1; x <= N; x++)
{
    Console.Write(basket[x] + " ");
}