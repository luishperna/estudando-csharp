using System;
using System.IO.Pipes;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 11 - Investimento a Longo Prazo");

        double fatorRentimento = 1.005;
        double investimento = 1000;

        // Encadeando laços for
        for (int anos = 1; anos <= 5; anos++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRentimento;
            }
            fatorRentimento += 0.001;
        }

        Console.WriteLine("Depois de 5 anos você terá R$ " + investimento);

        Console.WriteLine("Tecle enter para fechar.");
        Console.ReadLine();
    }
}