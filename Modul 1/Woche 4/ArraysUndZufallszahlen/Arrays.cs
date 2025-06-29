﻿namespace ArraysUndZufallszahlen
{
    public static class Arrays
    {
        public static void Uebung1()
        {
            int[] zahlen = new int[5];
            int summe = 0;

            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.Write($"Geben Sie Zahl {i + 1} ein: ");
                zahlen[i] = Convert.ToInt32(Console.ReadLine());
                summe += zahlen[i];
            }

            Console.WriteLine($"Die Summe der Zahlen ist: {summe}");
        }

        public static void BeispielMatrix()
        {
            int[,] matrix =
            {
                  {1, 2, 3},
                  {4, 5, 6},
                  {7, 8, 9}
            };

            for (int zeile = 0; zeile < matrix.GetLength(0); zeile++)
            {
                for (int spalte = 0; spalte < matrix.GetLength(1); spalte++)
                {
                    Console.Write(matrix[zeile, spalte] + " ");
                }
                Console.WriteLine();
            }


        }

        public static void CharMatrix()
        {

            const int matrixLaenge = 3;
            char[,] matrix = new char[matrixLaenge, matrixLaenge];

            Ausgabe();

            for (int i = 0; i < matrixLaenge; i++)
            {
                for (int j = 0; j < matrixLaenge; j++)
                {
                    Console.WriteLine("Geben Sie einen Wert für Zeile " + i + " und Spalte " + j);
                    matrix[i, j] = char.Parse(Console.ReadLine().Substring(0, 1));
                    Ausgabe();
                }
            }


            void Ausgabe()
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write("|");
                        Console.Write(Replace(matrix[i, j]));
                        Console.Write("|");

                    }
                    Console.WriteLine();
                }
            }

            char Replace(char ch)
            {
                return ch == 0 ? ' ' : ch;
            }
        }

        public static void Dynamisch()
        {
            string[] ret = [];

            Console.WriteLine("Das Array hat " + ret.Length + " Stellen. Wollen Sie es um ein Feld vergrößern?");
            var antwort = Console.ReadLine().ToLower() == "ja";
            while (antwort)
            {
                Array.Resize(ref ret, ret.Length + 1);

                Console.WriteLine("Noch um ein Feld vergrößern?");
                antwort = Console.ReadLine().ToLower() == "ja";
            }

            Console.WriteLine("Das Array hat nun " + ret.Length + " Stellen.");
        }

        public static void UebungMitDynamischemArray()
        {
            int[] arr = [];
            var multiplResult = 1;
            var multiplResult2 = 1;
            bool abgebrochen;

            do
            {
                Console.WriteLine("Geben Sie eine Zahl ein.");
                var strZahl = Console.ReadLine();
                abgebrochen = (strZahl?.ToUpper() == "A");
                if (abgebrochen)
                    break;
                if (!int.TryParse(strZahl, out int result))
                {
                    Console.WriteLine("Die Eingabe war falsch.");
                    continue;
                }
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.GetUpperBound(0)] = result;
                multiplResult *= result;
            }
            while (!abgebrochen);
            
            if (arr.Length == 0)
                return;

            Console.WriteLine("Erg. 1: "+ multiplResult);


            for(var i = 0; i < arr.Length; i++)
            {
                multiplResult2 *= arr[i];
            }

            Console.WriteLine("Erg. 2: " + multiplResult2);

            var istGleich = (multiplResult == multiplResult2);
            Console.WriteLine("Beide gleich? " + istGleich);           
        }
    }
}
