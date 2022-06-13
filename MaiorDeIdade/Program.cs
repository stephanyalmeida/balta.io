using System;

namespace VerificaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
          int idade = 0;
          int qtd = 0;
          int i = 0;

          while(i < 10)
          {
             Console.WriteLine("Digite a idade:");
             idade = Convert.ToInt32(Console.ReadLine());
             i++;

            if(idade >= 18){
                qtd++;
            }
          }

          Console.WriteLine("A quantidade de maiores de 18 anos é:" + qtd);
          

           Console.ReadKey();
        }
    }
}
