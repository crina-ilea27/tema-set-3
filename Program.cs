using System;

namespace ex_2_27_ian
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i,k,s=0;
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            string[] vec = Console.ReadLine().Split(" ");
            int[] t = new int[n];
            for (i = 0; i < n; i++)
            {
                t[i] = int.Parse(vec[i]);
            }
            for (i = 0; i < n; i++)
            {
                if (s == 0)
                {
                    if (t[i] == k)
                    {
                        Console.WriteLine(i+1);
                        s++;
                    }
                }
            }
            if (s == 0)
                Console.WriteLine(-1);
        }
    }
}
