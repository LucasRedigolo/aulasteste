using System;

namespace aulasteste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o ultimo digito da sua placa:");

            string Placa = Console.ReadLine();

            switch(Placa){
                case "1":
                    System.Console.WriteLine("Segunda-Feira");
                break;
                case "2":
                    System.Console.WriteLine("Terça-Feira");
                break;
                case "3":
                    System.Console.WriteLine("Quarta-Feira");
                break;
                case "4":
                    System.Console.WriteLine("Quinta-Feira");
                break;
                case "5":
                    System.Console.WriteLine("Sexta-Feira");
                break;

            }
        }
    }
}
