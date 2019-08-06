using System;

namespace _0301A1Rabatt
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal ep;    // Einzelpreis in EUR
            decimal n;     // Anzahl in Stück
            decimal gp;    // Gesamtpreis in EUR
            decimal r = 1; // Rabattfaktor 

            Console.Write("Bitte geben Sie den Einzelpreis in EUR ein: ");
            ep = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Bitte geben Sie die Anzahl in Stück ein: ");
            n = Convert.ToDecimal(Console.ReadLine());

            gp = n * ep;

            if (n > 50)
                r = 0.90M;  // 10 % Rabatt
            else
                if (n > 10)
                r = 0.95M; // 5 % Rabatt

            if (r < 1)
                Console.WriteLine("Zwischensumme :{0,10:F2}", gp);

            Console.WriteLine("Gesamt        :{0,10:F2}", Decimal.Multiply(gp, r));

        }
    }
}
