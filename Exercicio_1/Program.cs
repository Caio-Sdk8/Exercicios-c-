using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Idade\n");

            Console.WriteLine("Qual a sua idade em:");

            Console.Write("Anos: ");
            double anos = double.Parse(Console.ReadLine());

            Console.Write("meses: ");
            double meses = double.Parse(Console.ReadLine());
            
            Double idmeses = ((anos * 12) + meses);
            Double dias = (anos * 365) + (30 * meses);
            Double minutos = (dias * 1440 );

            Console.WriteLine ("Sua idade é em:");
            Console.WriteLine ("Anos: " + anos);
            Console.WriteLine ("Meses: " + idmeses);
            Console.WriteLine ("Dias: " + dias);
            Console.WriteLine ("Minutos: " + minutos);
        }
    }
}
