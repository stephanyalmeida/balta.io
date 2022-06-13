using System;

namespace VerificaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
          int n = 0;

          Console.WriteLine("Digite um número:");
          n = Convert.ToInt32(Console.ReadLine());
          int r = n % 2;

          if (r == 0){
              Console.WriteLine("O número é par");
          } 
          else{
             Console.WriteLine("O número é impar");  
          } 

           Console.ReadKey();
        }
    }
}
