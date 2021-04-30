using System;

namespace exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nadadores");

            Console.WriteLine("Olá atleta!, qual a sua idade?");
            Double idade = Double.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Ora ora um experiente, parabéns nadador você já é um Sênior");
            }
            if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("Já está ficando velho, sua turma é a Juvenil B");
            }
            if (idade >= 11 && idade <= 13)
            {
                Console.WriteLine("Você está no meio de sua jornada, mas ainda tem muito a aprender, está na turma é a Juvenil A");
            }
            if (idade >= 8 && idade <= 10)
            {
                Console.WriteLine("Você é um jovem nadador, sua turma é o Infantil B");
            }
            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Você é um iniciante, sua turma é o Infantil A");
            }
        }
    }
}
