using System;

namespace Altura
{
    class Program
    {
        static void Main(string[] args)
        {
           double altura = 0;
           double guarda = 0;
           int matricula = 0;
           int matr = 0; 
           int i = 0;
          
         while(i < 5)
         {
           Console.WriteLine("Digite a altura:");
           altura = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("Digite a matricula:");
           matricula =  Convert.ToInt32(Console.ReadLine());
           if(altura > guarda){
              guarda = altura;
              matr = matricula; 
           }
           i++;
         } 

         Console.WriteLine("O aluno mais alto é o de matricula:"+ matr);

         Console.ReadKey();
        }
    }
}
