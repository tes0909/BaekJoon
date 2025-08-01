int[] number = new int[9];
        int max = int.MinValue;
        int index = 0;

        for (int i = 0; i < 9; i++)
        {
            number[i] = int.Parse(Console.ReadLine());

            if (number[i] > max)
            {
                max = number[i];
                index = i + 1;
            }
        }
        Console.WriteLine(max);
        Console.WriteLine(index);