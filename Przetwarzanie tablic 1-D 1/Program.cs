using System;

//Linq on ex: https://e.wsei.edu.pl/mod/quiz/attempt.php?attempt=121323&cmid=19232&page=1

namespace Przetwarzanie_tablic_1_D_1
{
    class Program
    {

        //Nie zrobiony punkt - Nie wypisuj duplikatów.

        static void Main(string[] args)
        {
            int[] a = new int[] { -2, -1, 0, 1, 4 };
            int[] b = new int[] { -3, -2, -1, 1, 2, 3 };

            bool empty = true;
            int i = 0; int j = 0;
            while (i < a.Length && j < b.Length)
            {
                if (a[i] > b[j])
                {
                    j++;
                }
                else if (a[i] == b[j])
                {
                    Console.Write(a[i] + " ");
                    i++;
                    j++;
                    empty = false;
                }
                else { i++; }
            }

            if (empty)
            {
                Console.Write("empty");
            }
        }
    }
}
