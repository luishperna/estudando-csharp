using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 7 - Condicionais 2");

        int idadeLuis = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
        bool grupo = false;

        if (idadeLuis >= 18 || acompanhado || grupo)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
        }

        Console.WriteLine("Tecle enter para fechar.");
        Console.ReadLine();
    }
}