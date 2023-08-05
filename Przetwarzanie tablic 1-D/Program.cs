using System;

//Linq on ex: https://e.wsei.edu.pl/mod/quiz/attempt.php?attempt=121323&cmid=19232

namespace Przetwarzanie_tablic_1_D
{
    class Program
    {

        //Nie zrobiony punkt - Nie wypisuj duplikatów.

        static void Main(string[] args)
        {
            int[] a = new int[] { -2, -1, 0, 1, 4 };
            int[] b = new int[] { -3, -2, -1, 1, 2, 3 };

            int i = 0; int j = 0;
            bool empty = true;

            while (i < a.Length && j < b.Length)
            {
                if (a[i] > b[j])
                {
                    j++;
                }
                else if (a[i] == b[j])
                {
                    i++;
                    j++;
                }
                else //a<b - //Podstawowa tabela jest A  //w tabl A niegdy nie moze być a<b
                {
                    Console.Write(a[i] + " ");
                    i++;
                    empty = false;

                }

            }


            while (i < a.Length)
            {
                Console.Write(a[i] + " ");
                i++;
                empty = false;
            }

            if (empty)
            {
                Console.Write("empty");
            }

        }

    }
}
