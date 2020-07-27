using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w programie testującym parzystość liczby!");

            Console.WriteLine("\nPodaj liczbę, a komputer sprawdzi, czy jest ona parzysta czy nieparzysta: ");

            try
            {
                if (!int.TryParse(Console.ReadLine(), out int userNumber))
                    throw new Exception("Podana wartość jest nieprawidłowa!");
                if (userNumber % 2 == 0)
                    Console.WriteLine("Podana liczba jest parzysta.");
                else
                    Console.WriteLine("Podana liczba jest nieparzysta.");

                Console.WriteLine("\nDziękuję za skorzystanie z programu!");
            }

            catch (Exception ex)
            {
                //Logowanie do pliku
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć program i wyjść.");
                Console.ReadKey();
            }

        }
    }
}
