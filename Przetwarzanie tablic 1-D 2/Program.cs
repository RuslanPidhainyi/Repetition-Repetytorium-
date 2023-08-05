using System;

//Linq on ex: https://e.wsei.edu.pl/mod/quiz/attempt.php?attempt=121323&page=2&cmid=19232#

namespace Przetwarzanie_tablic_1_D_2
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
            
            while(i < a.Length && j < b.Length)
            {
                if (a[i] == b[j])
                {
                    i++;
                    j++;
                }
                else if (a[i] < b[j])
                {
                    Console.Write(a[i] + " ");
                    i++;
                    empty = false;
                } 
                else if (a[i] > b[j])
                {
                    Console.Write(b[j]+ " ");
                    j++;
                    empty = false;
                }

            }

            while (i < a.Length)
            {
                Console.Write(a[i]+" ");
                i++;
                empty = false;
            }

            while(j < b.Length) 
            {
                Console.Write(b[j] + " ");
                j++;
                empty = false;
            }

            if(empty)
            {
                Console.Write("empty");
            }    

        }
    }
}
