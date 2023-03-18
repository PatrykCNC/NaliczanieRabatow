using System;

namespace NaliczanieRabatow
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz cene:");
            int cena = int.Parse(Console.ReadLine());

            if (cena > 400)
            {
                cena -= 80;
                    Console.WriteLine("Rabat: 80");
            }
            else
            {
                if (cena > 200)
                {
                    cena -= 35;
                        Console.WriteLine("Rabat: 35");
                }
                else
                {
                    if (cena > 100)
                    {
                        cena -= 15;
                        Console.WriteLine("Rabat: 15");
                    }
                    else
                    {
                        Console.WriteLine("Brak rabatu");
                    }
                }
            }
            Console.WriteLine("Cena koncowa: ");
            Console.WriteLine(cena);

        }
    }
}