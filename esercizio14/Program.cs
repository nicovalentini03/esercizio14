using System;

namespace esercizio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il prezzo del primo prodotto: ");
            double prodotto1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il prezzo del secondo prodotto: ");
            double prodotto2 = double.Parse(Console.ReadLine());
            double sconto;
            double scontato;
            double totale;
            if (prodotto1 > prodotto2)
            {
                sconto = prodotto2 / 100 * 50;
                scontato = prodotto2 - sconto;
                totale = prodotto1 + scontato;
                Console.WriteLine($"Lo sconto è di {sconto} euro e il prezzo da pagare {totale} euro");
            }
            else
            {
                sconto = prodotto1 / 100 * 50;
                scontato = prodotto1 - sconto;
                totale = prodotto2 + scontato;
                Console.WriteLine($"Lo sconto è di {sconto} euro e il prezzo da pagare {totale} euro");
            }
            Console.ReadLine();
        }
    }
}
