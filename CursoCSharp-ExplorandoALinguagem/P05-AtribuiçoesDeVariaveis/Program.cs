using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5 - Atribuições de Variáveis");

        int idade = 20;
        int idadeLuis = idade;

        Console.WriteLine(idadeLuis);

        // Por mais que foi atribuito outro valor a variável idade, a 
        // variável idadeLuis não é alterada, pois o código já atribuiu um
        // valor inicial e não atribui novamente de forma automática
        // As atribuições de variáveis seguem o fluxo linear do código;
        idade = 25;
        Console.WriteLine(idade);
        Console.WriteLine(idadeLuis);

        Console.WriteLine("Pressione a tecla enter para fechar.");
        Console.ReadLine();

    }
}
