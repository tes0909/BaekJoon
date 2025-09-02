bool[] submit = new bool[31];

for (int i = 0; i < 28; i++)
{
    int n = int.Parse(Console.ReadLine());
    submit[n] = true;
}

for (int i = 1; i <= 30; i++)
{
    if(!submit[i])
    {
        Console.WriteLine(i);
    }
}