class ZD2
{
    /* Задана матрица A(n,m). Обнулить ту строку, где находится наибольшее число. */
    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());  
        Console.Write("m = ");
        int m = int.Parse(Console.ReadLine());
        int[,] DubArray = new int[n,m];
        Random random = new Random();
        int maxRowIndex = 0;


        for (int i = 0; i < DubArray.GetLength(0); i++)
        {
            for (int j = 0; j < DubArray.GetLength(1); j++)
            {
                DubArray[i, j] = random.Next(10);
            }
            Console.WriteLine();
        }

        for (int i = 0; i < DubArray.GetLength(0); i++)
        {
            for (int j = 0; j < DubArray.GetLength(1); j++)
            {
                Console.Write(DubArray[i,j] + "\t");
            }
            Console.WriteLine();
        }
        int max_elem = DubArray[0, 0];

        for (int i = 0; i < DubArray.GetLength(0); i++)
        {
            for (int j = 0; j < DubArray.GetLength(1); j++)
            {
                if (DubArray[i, j] > max_elem)
                {
                    max_elem = DubArray[i, j];
                    maxRowIndex = i;
                }
            }
        }
        Console.WriteLine(max_elem);


        for (int j = 0; j < DubArray.GetLength(0); j++)
        {
            DubArray[maxRowIndex, j] = 0;
        }

        for (int i = 0; i < DubArray.GetLength(0); i++)
        {
            for (int j = 0; j < DubArray.GetLength(1); j++)
            {
                Console.Write(DubArray[i, j] + "\t");
            }
            Console.WriteLine();
        }
    } 
}