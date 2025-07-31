string[] input = Console.ReadLine().Split();
int n = int.Parse(input[0]);
int x = int.Parse(input[1]);
string[] sequence = Console.ReadLine().Split();
for (int i = 0; i < n; i++)
{
    if(int.Parse(sequence[i]) < x)
    {
        Console.Write(sequence[i] + " ");
    }
}