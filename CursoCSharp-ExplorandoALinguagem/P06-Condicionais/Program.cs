using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 6 - Condicionais");

        int idadeLuis = 16;
        int quantidadePessoas = 2;

        if (idadeLuis >= 18)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            if (quantidadePessoas > 1)
            {
                Console.WriteLine("Ele está acompanhado, pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar!");
            }
        }

        Console.WriteLine("Tecle enter para fechar.");
        Console.ReadLine();
    }
}