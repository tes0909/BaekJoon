string[] input = Console.ReadLine().Split(' ');
        int N = int.Parse(input[0]); // 바구니
        int M = int.Parse(input[1]); // 공

        int[] basket = new int[N + 1];

        for (int x = 1; x <= N; x++)
        {
            basket[x] = x;
        }
        
        for (int x = 1; x <= M; x++)
        {
            string[] method = Console.ReadLine().Split(' ');
            int i = int.Parse(method[0]);
            int j = int.Parse(method[1]);
            (basket[i], basket[j]) = (basket[j], basket[i]);
        }

        for (int i = 1; i <= N; i++)
        {
            Console.Write(basket[i] + " ");
        }