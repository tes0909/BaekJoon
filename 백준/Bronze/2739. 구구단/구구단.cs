int number = Convert.ToInt32(Console.ReadLine());
int answer = 0;
for (int i = number; i <= number; i++)
{
    for (int j = 1; j <= 9; j++)
    {
        answer = i * j;
        Console.WriteLine(i + " * " + j + " = " + answer);
    }
}
