int number = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < number; i++)
{
    string[] input = Console.ReadLine().Split( );
    int a = Convert.ToInt32(input[0]);
    int b = Convert.ToInt32(input[1]);
    Console.WriteLine(a + b);
}