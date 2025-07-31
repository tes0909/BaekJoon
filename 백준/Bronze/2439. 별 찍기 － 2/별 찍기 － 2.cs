using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        int number = int.Parse(sr.ReadLine());
       
        for (int i = 0; i < number; i++)
        {
            for (int j = 0; j < number - i - 1; j++)
            {
                sw.Write(" ");
            }
            
            for (int j = 0; j <= i; j++)
            {
                sw.Write("*");
            }
            sw.WriteLine();
        }