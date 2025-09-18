int[,] paper = new int[100, 100];
int area = 0;
int number = int.Parse(Console.ReadLine());

for (int i = 0; i < number; i++)
{
    string[] input = Console.ReadLine().Split();
    int x = int.Parse(input[0]);
    int y = int.Parse(input[1]);
    for (int j = x; j < x + 10; j++)
    {
        for (int k = y; k < y + 10; k++)
        {
            if(paper[j, k] == 0)
            {
                paper[j, k] = 1;
                area++;
            }
        }
    }
}
Console.WriteLine(area);