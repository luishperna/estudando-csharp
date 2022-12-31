using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 1 - Criando Variáveis");

        int idade;

        idade = 20;
        Console.WriteLine("Minha idade é " + idade);

        idade = 27 - 5;
        Console.WriteLine(idade);

        idade = 5 * 2 - 6;
        Console.WriteLine(idade);

        idade = (5 - 2) * 3;
        Console.WriteLine(idade);

        Console.WriteLine("Pressione enter para fechar.");
        Console.ReadLine();

    }
}