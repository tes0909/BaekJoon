int N = int.Parse(Console.ReadLine());
double[] beforeScore = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

double M = beforeScore.Max();
double sum = 0;
for (int i = 0; i < N; i++)
{
    sum += beforeScore[i]/ M * 100;
    
}
double averageScore = sum / N;
        
Console.WriteLine(averageScore);