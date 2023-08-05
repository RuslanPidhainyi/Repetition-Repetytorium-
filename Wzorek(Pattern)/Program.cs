using System;

namespace Wzorek_Pattern_
{
    internal class Program
    {
        //Link on ex:https://e.wsei.edu.pl/mod/quiz/attempt.php?attempt=121078&cmid=19206

        //guid:https://www.youtube.com/watch?v=xzstcj3Cuso&ab_channel=SimplyCoding

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Int32.TryParse(input, out int n);
            //square(n);
            //examination(n);
            //RightSidedTriangle(n);
            Wzorek(n);
            //Wzorek1(n);








        }


        public static void Wzorek(int n)
        {
            if (n % 2 != 0)
            {

                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j < i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = i; j <= n; j++)
                    {
                        Console.Write("*");
                        if (j == n)
                        {
                            n = n - 1;
                        }
                    }
                    Console.WriteLine();
                }
            }
            else if (n % 2 == 0)
            {
                n = n - 1;

                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j < i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = i; j <= n; j++)
                    {
                        Console.Write("*");
                        if (j == n)
                        {
                            n = n - 1;
                        }
                    }
                    Console.WriteLine();
                }

            }
        }






        public static void Wzorek1(int n)
        {

            if (n % 2 != 0)
            {

                for (int i = 1; i <= n; i++)
                {
                    if (i == 1)
                    {

                        for (int j = 0; j < i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = i; j <= n; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();

                    }
                    else if (i > 1)
                    {
                        n = n - 1;

                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = i; j <= n; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();

                    }
                }
            }
            else if(n % 2 == 0)
            {
                n = n - 1;

                for (int i = 1; i <= n; i++)
                {
                    if (i == 1)
                    {

                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = i; j <= n; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();

                    }
                    else if (i > 1)
                    {
                        n = n - 1;

                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = i; j <= n; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();

                    }
                }

            }
        }




















        public static void RightSidedTriangle(int n)
        {
            for(int i = 1; i <=n; i++)//rows 
            { 
                for(int j = i; j <=n;j++)//column ampty
                {
                    Console.Write("  ");
                }
                for(int j = 1; j<=i;j++)
                {
                    Console.Write("* ");//draw colums 
                }
                Console.WriteLine();
            }
        }




        public static void square(int n)
        {
            for(int i = 1; i <= n; i++)//rows
            {
                for (int j = 1; j <= n; j++)//colums
                {
                    Console.Write("*");
                }
                Console.WriteLine();//draw with new lines, after rows  
            }
        }


        public static void examination(int n)
        {
            if(n % 2 == 1)//1 - true
            {
                Console.WriteLine($"{n}" + " Np");
            }
            else if(n % 2 == 0)//0 - false
            {
                Console.WriteLine($"{n}" + " p");
            }
        }
    }
}
