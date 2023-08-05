using System;

namespace LED_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //0 enter digitals

            //1 digital LED symbols

            //2 convertation from numbers to LED symbols 

            //3 show to symbols LED



            


            // wczytaj liczbę jako ciąg znaków
            string liczba = Console.ReadLine();

            // utwórz tablicę z ciągami znaków reprezentującymi każdą cyfrę LED
            string[] cyfry = new string[] {
      " _     _  _     _  _  _  _  _ ",
      "| |  | _| _||_||_ |_   ||_||_|",
      "|_|  ||_  _|  | _||_|  ||_| _|"
    };

            // dla każdej linii z cyframi LED
            for (int i = 0; i < 3; i++)
            {
                // dla każdej cyfry w liczbie
                for (int j = 0; j < liczba.Length; j++)
                {
                    // wyznacz indeks początkowy i końcowy w tablicy cyfr dla tej cyfry
                    int indeks = liczba[j] - '0';
                    int start = indeks * 3;
                    int koniec = start + 3;

                    // wydrukuj odpowiedni fragment linii
                    Console.Write(cyfry[i].Substring(start, 3));

                    // dodaj spację poza ostatnią cyfrą
                    if (j < liczba.Length - 1)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

}



