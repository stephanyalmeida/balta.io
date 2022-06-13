using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 0;
            double id1 = 0;
            double id2 = 0;
            double id3 = 0;
            double id4 = 0;
            double id5 = 0;

            Console.WriteLine("Calcular a média de 5 idades: ");
            Console.WriteLine("Digite a primeira idade: ");
            id1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda idade:");
            id2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira idade:");
            id3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quarta idade:");
            id4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quinta idade:");
            id5 =  Convert.ToDouble(Console.ReadLine());

            media = (id1 + id2 + id3 + id4 + id5) / 5;

            Console.WriteLine("A média das idades é:" + media);
                 
            Console.ReadKey();

        }
    }
}