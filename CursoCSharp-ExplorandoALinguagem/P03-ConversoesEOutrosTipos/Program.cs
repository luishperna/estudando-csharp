using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 3 - Conversões e Outros Tipos");

        double salario = 3000.15;

        int salarioInteiro;
        // Cast de double para inteiro
        salarioInteiro = (int)salario;

        // O long é um tipo de variável de 64 bits
        long x = 2000000000000000000;

        // O short é um tipo de variável de 16 bits
        short y = 15000;

        float altura = 1.62f;

        Console.WriteLine("Salário: " + salario);
        Console.WriteLine("Salário Inteiro: " + salarioInteiro);
        Console.WriteLine("X: " + x);
        Console.WriteLine("Y: " + y);
        Console.WriteLine("Altura: " + altura);

        Console.WriteLine("Pressione enter para fechar.");
        Console.ReadLine();

    }
}
