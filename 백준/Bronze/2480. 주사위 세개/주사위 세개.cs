string[] number = Console.ReadLine().Split();
int a = int.Parse(number[0]);
int b = int.Parse(number[1]);
int c = int.Parse(number[2]);
int reward = 0;
if(a == b && a == c)
{
    reward = 10000 + a * 1000;
}
else if (a == b || a == c)
{
    reward = 1000 + a * 100;
}
else if (b == c)
{
    reward = 1000 + b * 100;
}
else
{
    int max = Math.Max(a, Math.Max(b, c));
    reward = max * 100;
}
Console.WriteLine(reward);