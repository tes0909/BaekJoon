int number = int.Parse(Console.ReadLine());
int count = 0;
while(number >= 0)
{
    if (number % 5 == 0)
    {
        count += number / 5;
        Console.WriteLine(count);
        return;
    }
    
    number -= 3;
    count++;
}
Console.WriteLine(-1);