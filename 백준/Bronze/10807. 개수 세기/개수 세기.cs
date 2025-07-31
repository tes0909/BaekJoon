using var sr = new StreamReader(Console.OpenStandardInput());
using var sw = new StreamWriter(Console.OpenStandardOutput());
int number = int.Parse(sr.ReadLine());
string[] input = sr.ReadLine().Split(' ');
int v = int.Parse(sr.ReadLine());
int count = 0;
for (int i = 0; i < number; i++)
{
    if(int.Parse(input[i]) == v)
    {
        count++;
    }
}
sw.WriteLine(count);