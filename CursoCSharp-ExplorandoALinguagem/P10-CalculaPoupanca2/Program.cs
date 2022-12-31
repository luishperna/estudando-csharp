using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Calcula Poupança 2");

        /*
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você tem R$" + investimento);

            // mes = mes + 1;
            // mes ++ (Quando for somar apenas 1)
            mes += 1;
        }
        */

        double investimento = 1000;

        for (int mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você tem R$" + investimento);
        }

        Console.WriteLine("Tecle enter para fechar.");
        Console.ReadLine();
    }
}