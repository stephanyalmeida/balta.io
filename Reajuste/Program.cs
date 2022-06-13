using System;

namespace Reajuste
{
    class Program
    {
        static void Main(string[] args)
        {
           double salario = 0;

           Console.WriteLine("Digite o salário: ");
           salario = Convert.ToDouble(Console.ReadLine());

           if(salario <= 300){
               salario = salario + (salario * 0.5); 
           }
           else{
               salario = salario + (salario * 0.3);
           }

         Console.WriteLine("O reajuste salarial é: " +  salario);  
         Console.ReadKey();
        }
    }
}