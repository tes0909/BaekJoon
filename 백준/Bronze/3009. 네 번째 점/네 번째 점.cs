var points = new (int x, int y)[3];
for (int i = 0; i < 3; i++)
{
    string[] input = Console.ReadLine().Split();
    int x = int.Parse(input[0]);
    int y = int.Parse(input[1]);
    points[i] = (x, y);
    
    
}
int missX = points[0].x ^ points[1].x ^ points[2].x;
    int missY = points[0].y ^ points[1].y ^ points[2].y;
    Console.WriteLine($"{missX} {missY}");