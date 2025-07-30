using var sr = new StreamReader(Console.OpenStandardInput());
using var sw = new StreamWriter(Console.OpenStandardOutput());
int number = int.Parse(sr.ReadLine());
for (int i = 0; i < number; i++)
{
    string[] input = sr.ReadLine().Split(' ');
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);
    sw.WriteLine($"Case #{i + 1}: {a + b}");
}