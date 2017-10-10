using System;

namespace aulasteste
{
    class Program
    
    {
        static void Main (string [] arg)

        
        {

       double NotadoAluno = 8.5;

       System.Console.WriteLine("Calculando Nota....");
       System.Threading.Thread.Sleep(5000);
  
       if (NotadoAluno>7)

        System.Console.WriteLine("Aluno Aprovado");
        
       else if (NotadoAluno <7 && NotadoAluno  >5)
       
       System.Console.WriteLine("Aluno Reprovado");     
    

        }
    }
}