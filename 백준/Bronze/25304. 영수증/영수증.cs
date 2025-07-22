int totalPrice = int.Parse(Console.ReadLine());
int count = int.Parse(Console.ReadLine());
int price = 0;
for (int i = 1; i <= count; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);
    price += a * b;
}
Console.WriteLine(price == totalPrice ? "Yes" : "No");