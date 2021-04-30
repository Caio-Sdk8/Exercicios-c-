using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reajuste de salário");

            Console.WriteLine("Olá funcionário, qual o seu salário (sem necessidade da moeda)?");
            double salario = double.Parse(Console.ReadLine());

            double reajuste = ((salario * 0.3) + salario);

            if (salario <= 500)
            { 
                Console.WriteLine ("Após o reajuste oferecido pela empresa, seu novo salário é " + reajuste);
            }
            else {
                Console.WriteLine("Você não está apto a receber o reajuste, tenha um bom dia");
            }
        }
    }
}
