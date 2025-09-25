using System.Security.Cryptography.X509Certificates;

namespace DSAStriver._1._Patterns
{
    public class Pattern
    {
        public void Spacing(string patternName)
        {
            Console.WriteLine();
            Console.WriteLine($"Next pattern {patternName}");
            Console.WriteLine();
        }
        public void print1(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        public void print2(int n)
        {
            Spacing("2 Triangle");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void print3(int n)
        {
            Spacing("3 Number Triangle");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(j + 1);
                }
                Console.WriteLine();
            }
        }

        public void print4(int n)
        {
            Spacing("4 Number Triangle");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(i + 1);
                }
                Console.WriteLine();
            }
        }

        public void print5(int n)
        {
            Spacing("5 Reverse Triangle");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (n - i); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void print6(int n)
        {
            Spacing("6 Reverse Number Triangle");
            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <= (n - i + 1); j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public void print7(int n)
        {
            //Spacing("7 Pyramid with Spacing");
            for (int i = 0; i < n; i++)
            {             // for rows
                for (int j = 0; j < (n - i - 1); j++)
                {  // for left side space
                    Console.Write("-");
                }
                for (int k = 0; k < (2 * i + 1); k++)
                {   // for stars
                    Console.Write("*");
                }
                for (int l = 0; l < (n - i - 1); l++)
                { // for rigth side space
                    Console.Write("-");
                }
                Console.WriteLine();
            }
        }

        public void print8(int n)
        {
            //Spacing("8 Reverse Pyramid with Spacing");
            for (int i = 0; i < n; i++)
            {             // for rows
                for (int j = 0; j < i; j++)
                {          // for left side space
                    Console.Write("-");
                }
                for (int k = 0; k < 2 * (n - i) - 1; k++)
                {
                    Console.Write("*");
                }
                for (int l = 0; l < i; l++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
        }

        public void print9(int n)
        {
            Spacing("9 Diamond (combination of 7 and 8)");
            print7(5);
            print8(5);
        }

        public void print10(int n)
        {
            Spacing("10 Triangle");
            //for (int i = 0; i <= n; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int k = 0; k < n; k++)
            //{
            //    for (int l = 0; l <= (n - k - 1); l++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            // above also works
            Console.WriteLine();

            for (int i = 1; i <= (2 * n - 1); i++)
            {
                int stars = i > n ? (2 * n - i) : i;

                for (int j = 1; j <= stars; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void print11(int n)
        {
            Spacing("1 0 1 0 Triangle");
            int Count = 1;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0) Count = 1;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(Count);
                    Count = 1 - Count;
                }
                Console.WriteLine();
            }
        }
    }
}
