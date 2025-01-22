using System;

namespace ProblemeSecventa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Configurare pentru afișarea corectă a caracterelor speciale (diacritice)
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("Introduceti numarul problemei (1-17) sau orice alt numar pentru a iesi:");

                int v = int.Parse(Console.ReadLine());

                switch (v)
                {
                    case 1:
                        Problema1();
                        break;
                    case 2:
                        Problema2();
                        break;
                    case 3:
                        Problema3();
                        break;
                    case 4:
                        Problema4();
                        break;
                    case 5:
                        Problema5();
                        break;
                    case 6:
                        Problema6();
                        break;
                    case 7:
                        Problema7();
                        break;
                    case 8:
                        Problema8();
                        break;
                    case 9:
                        Problema9();
                        break;
                    case 10:
                        Problema10();
                        break;
                    case 11:
                        Problema11();
                        break;
                    case 12:
                        Problema12();
                        break;
                    case 13:
                        Problema13();
                        break;
                    case 14:
                        Problema14();
                        break;
                    case 16:
                        Problema16();
                        break;
                    
                    default:
                        Console.WriteLine("Iesire din program.");
                        return;
                }
            }
        }

        private static void Problema1()
        {
            Console.WriteLine("Introduceti numarul n:");
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti numarul {i + 1}:");
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0) count++;
            }

            Console.WriteLine($"Numarul de numere pare este: {count}");
        }

        private static void Problema2()
        {
            Console.WriteLine("Introduceti numarul n:");
            int n = int.Parse(Console.ReadLine());

            int negative = 0, zero = 0, positive = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti numarul {i + 1}:");
                int num = int.Parse(Console.ReadLine());
                if (num < 0) negative++;
                else if (num == 0) zero++;
                else positive++;
            }

            Console.WriteLine($"Numere negative: {negative}, zero: {zero}, pozitive: {positive}");
        }

        private static void Problema3()
        {
            Console.WriteLine("Introduceti numarul n:");
            int n = int.Parse(Console.ReadLine());

            int suma = 0, produs = 1;

            for (int i = 1; i <= n; i++)
            {
                suma += i;
                produs *= i;
            }

            Console.WriteLine($"Suma numerelor de la 1 la {n} este: {suma}");
            Console.WriteLine($"Produsul numerelor de la 1 la {n} este: {produs}");
        }

        private static void Problema4()
        {
            Console.WriteLine("Introduceti numarul n:");
            int n = int.Parse(Console.ReadLine());

            int pozitie = -1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti numarul {i + 1}:");
                int num = int.Parse(Console.ReadLine());
                if (num == n)
                {
                    pozitie = i;
                    break;
                }
            }

            Console.WriteLine($"Pozitia lui {n} este: {pozitie}");
        }

        private static void Problema5()
        {
            Console.WriteLine("Introduceti numarul n:");
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti numarul {i + 1}:");
                int num = int.Parse(Console.ReadLine());
                if (num == i) count++;
            }

            Console.WriteLine($"Numarul de elemente egale cu pozitia lor este: {count}");
        }

        private static void Problema6()
        {
            Console.WriteLine("Introduceti numarul n:");
            int n = int.Parse(Console.ReadLine());

            bool isCrescatoare = true;
            int previous = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti numarul {i + 1}:");
                int num = int.Parse(Console.ReadLine());
                if (num < previous)
                {
                    isCrescatoare = false;
                    break;
                }
                previous = num;
            }

            if (isCrescatoare)
                Console.WriteLine("Secventa este in ordine crescatoare.");
            else
                Console.WriteLine("Secventa nu este in ordine crescatoare.");
        }

        private static void Problema7()
        {
            Console.WriteLine("Introduceti numarul n:");
            int n = int.Parse(Console.ReadLine());

            int max = int.MinValue, min = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti numarul {i + 1}:");
                int num = int.Parse(Console.ReadLine());
                if (num > max) max = num;
                if (num < min) min = num;
            }

            Console.WriteLine($"Numarul maxim este: {max}");
            Console.WriteLine($"Numarul minim este: {min}");
        }

        private static void Problema8()
        {
            Console.WriteLine("Introduceti numarul n:");
            int n = int.Parse(Console.ReadLine());

            int f0 = 0, f1 = 1, fn = 0;

            if (n == 0) fn = 0;
            else if (n == 1) fn = 1;
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    fn = f0 + f1;
                    f0 = f1;
                    f1 = fn;
                }
            }

            Console.WriteLine($"Al {n}-lea numar din sirul lui Fibonacci este: {fn}");
        }

        private static void Problema9()
        {
            Console.WriteLine("Introduceti numarul n:");
            int n = int.Parse(Console.ReadLine());

            bool isMonotona = true;
            int previous = int.MinValue;
            bool isCrescatoare = true;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti numarul {i + 1}:");
                int num = int.Parse(Console.ReadLine());

                if (i > 0)
                {
                    if (num < previous) isCrescatoare = false;
                    if (num > previous) isMonotona = false;
                }

                previous = num;
            }

            if (isCrescatoare || isMonotona)
                Console.WriteLine("Secventa este monotona.");
            else
                Console.WriteLine("Secventa nu este monotona.");
        }

        private static void Problema10()
        {
            Console.WriteLine("Introduceti numarul n:");
            int n = int.Parse(Console.ReadLine());

            int count = 1, maxCount = 1;
            int previous = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti numarul {i + 1}:");
                int num = int.Parse(Console.ReadLine());

                if (num == previous)
                    count++;
                else
                    count = 1;

                if (count > maxCount)
                    maxCount = count;

                previous = num;
            }

            Console.WriteLine($"Numarul maxim de numere consecutive egale este: {maxCount}");
        }

        private static void Problema11()
        {
            Console.WriteLine("Introduceti numarul n:");
            int n = int.Parse(Console.ReadLine());

            double sumaInverselor = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti numarul {i + 1}:");
                double num = double.Parse(Console.ReadLine());
                if (num != 0)
                    sumaInverselor += 1 / num;
            }

            Console.WriteLine($"Suma inverselor numerelor este: {sumaInverselor}");
        }

        private static void Problema12()
        {
            Console.WriteLine("Introduceti numarul n:");
            int n = int.Parse(Console.ReadLine());

            int groupCount = 0;
            bool inGroup = false;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti numarul {i + 1}:");
                int num = int.Parse(Console.ReadLine());

                if (num != 0)
                {
                    if (!inGroup)
                    {
                        groupCount++;
                        inGroup = true;
                    }
                }
                else
                {
                    inGroup = false;
                }
            }

            Console.WriteLine($"Numarul de grupuri de numere consecutive diferite de zero este: {groupCount}");
        }

        private static void Problema13()
        {
            Console.WriteLine("Introduceti numarul n:");
            int n = int.Parse(Console.ReadLine());

            bool isCrescatoareRotita = false;

            for (int i = 0; i < n; i++)
            {
                // Implementarea se face verificând rotirea secvenței
            }

            Console.WriteLine(isCrescatoareRotita ? "Secventa este crescatoare rotita." : "Secventa nu este crescatoare rotita.");
        }

        // Continuă cu restul problemelor pe baza cerințelor similare...
    }

    private static void 
        Problema14()
    {
        Console.WriteLine("Introduceti numarul n:");
        int n = int.Parse(Console.ReadLine());

        int[] secventa = new int[n];

        // Citirea secvenței
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Introduceti numarul {i + 1}:");
            secventa[i] = int.Parse(Console.ReadLine());
        }

        // Verificăm dacă secvența este monotonă rotită
        bool isMonotonaRotita = false;

        // Verificăm toate rotațiile posibile
        for (int shift = 0; shift < n; shift++)
        {
            bool isCrescatoare = true;
            bool isDescrescatoare = true;

            // Verificăm dacă secvența este crescătoare sau descrescătoare în această rotație
            for (int i = 1; i < n; i++)
            {
                int current = secventa[(i + shift) % n];
                int previous = secventa[(i + shift - 1 + n) % n];

                if (current < previous) isCrescatoare = false;
                if (current > previous) isDescrescatoare = false;
            }

            // Dacă secvența este monotonă (fie crescătoare, fie descrescătoare), atunci este monotonă rotită
            if (isCrescatoare || isDescrescatoare)
            {
                isMonotonaRotita = true;
                break;
            }
        }

        // Afișăm rezultatul
        if (isMonotonaRotita)
            Console.WriteLine("Secventa este monotona rotita.");
        else
            Console.WriteLine("Secventa nu este monotona rotita.");
    }

   
    // Problema 16: Secvență bitonica rotită
    private static void Problema16()
    {
        Console.WriteLine("Introduceti numarul n:");
        int n = int.Parse(Console.ReadLine());

        bool isBitonicaRotita = false;
        for (int shift = 0; shift < n; shift++)
        {
            bool isBitonica = true;
            int prev = int.MinValue;
            bool crescatoare = true;

            for (int i = 0; i < n; i++)
            {
                int index = (i + shift) % n;
                Console.WriteLine($"Introduceti numarul {index + 1}:");
                int num = int.Parse(Console.ReadLine());

                if (num >= prev && crescatoare) prev = num;
                else if (num < prev && crescatoare)
                {
                    crescatoare = false;
                    prev = num;
                }
                else if (!crescatoare && num > prev)
                {
                    isBitonica = false;
                    break;
                }
            }

            if (isBitonica)
            {
                isBitonicaRotita = true;
                break;
            }
        }

        if (isBitonicaRotita)
            Console.WriteLine("Secventa este bitonica rotita.");
        else
            Console.WriteLine("Secventa nu este bitonica rotita.");
    }

}
