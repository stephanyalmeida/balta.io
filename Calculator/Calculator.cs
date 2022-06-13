using System;

namespace Calculator
{
    class Program
    {
       static void Main(string[] args)
       {
         Menu();
       }


   static void Menu()
   {
      Console.Clear();

      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Multiplicação");
      Console.WriteLine("4 - Divisão");
      Console.WriteLine("5 - Sair");

      Console.WriteLine("-------------");
      Console.WriteLine("Selecione uma opção:");

      short res = short.Parse(Console.ReadLine());

      switch(res)
      {
          case 1: Soma(); break;
          case 2: Subtracao(); break;
          case 3: Multiplicacao(); break;
          case 4: Divisao(); break;
          case 5: System.Environment.Exit(0); break;
          default: Menu(); break; 
      }
   }
       static void Soma()
       {
           Console.Clear();

           Console.WriteLine("Primeiro valor: ");
           float v1 = float.Parse(Console.ReadLine());

           Console.WriteLine("Segundo valor: ");
           float v2 = float.Parse(Console.ReadLine());

           float soma = v1 + v2;
          // Console.WriteLine("Soma:"+ soma);
           Console.WriteLine($"Soma: {soma}");
           //Console.WriteLine($"Soma: {v1+v2}");
           //Console.WriteLine("Soma:"+(v1+v2));
           Console.ReadKey();
           Menu(); 
       }

       static void Subtracao()
       {
           Console.Clear();
           
           Console.WriteLine("Primeiro valor: ");
           float v1 = float.Parse(Console.ReadLine());

           Console.WriteLine("Segundo valor: ");
           float v2 = float.Parse(Console.ReadLine());

           float subtracao = v1 - v2;
    
           Console.WriteLine($"Subtracao: {subtracao}");
           Console.ReadKey();
           Menu(); 
       }
     
     static void Multiplicacao()
     {
           Console.Clear();
          
           Console.WriteLine("Primeiro valor: ");
           float v1 = float.Parse(Console.ReadLine());

           Console.WriteLine("Segundo valor: ");
           float v2 = float.Parse(Console.ReadLine());

           float multiplicacao = v1 * v2;
    
           Console.WriteLine($"Multiplicacao: {multiplicacao}");
           Console.ReadKey();
           Menu(); 
       }

       static void Divisao()
       {
           Console.Clear();
           
           Console.WriteLine("Primeiro valor: ");
           float v1 = float.Parse(Console.ReadLine());

           Console.WriteLine("Segundo valor: ");
           float v2 = float.Parse(Console.ReadLine());

           float divisao = v1/v2;
    
           Console.WriteLine($"Divisao: {divisao}");
           Console.ReadKey();
           Menu(); 
       }


       
    }
}

