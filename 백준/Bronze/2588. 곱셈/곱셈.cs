int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = b % 10;
int d = (b / 10) % 10;
int e = b / 100;
Console.WriteLine(a * c);
Console.WriteLine(a * d);
Console.WriteLine(a * e);
Console.WriteLine(a * c + a * 10 * d + a * 100 * e);
