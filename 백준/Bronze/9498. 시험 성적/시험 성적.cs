int score = int.Parse(Console.ReadLine());
if (score < 0 || score > 100) return;
if(score >= 90)
{
    Console.WriteLine("A");
}
else if (score >= 80)
{
    Console.WriteLine("B");
}
else if(score >= 70)
{
    Console.WriteLine("C");
}
else if(score >= 60)
{
    Console.WriteLine("D");
}
else
{
    Console.WriteLine("F");
}