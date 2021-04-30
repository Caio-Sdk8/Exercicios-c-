using System;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Idade");

            Console.WriteLine("Olá usuario, me informe:" + "\n");
            
            Console.WriteLine("O ano em que você nasceu:");
            double anoidade = double.Parse(Console.ReadLine());

            int anoatual = DateTime.Now.Year;
            Double idade = ( anoatual - anoidade);
            Double idadesem = (idade * 52.1429);

            Console.WriteLine ("A sua idade é: " + idade);
            Console.WriteLine ("E em semanas, você viveu aproximadamente: " + idadesem);
            
        }
    }
}
