using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 4 - Caracteres e Textos");

        // Para atribuir um caracter ao tipo char é necessário usar aspas simples
        // Se atribuir com aspas duplas seria associado um texto e não um caracter
        char letra = 'a';
        Console.WriteLine(letra);

        // ASCII Table
        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(125 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - Cursos de Tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        // O tipo string pode ser vazio, já o tipo de char não
        string vazia = "";
        Console.WriteLine(vazia);

        // Usando o @ em string possibilita escrever em variarias linhas
        string cursos = @"Cursos disponéveis: 
-Go 
-C# 
-Python 
-Java";
        Console.WriteLine(cursos);


        Console.WriteLine("Pressione a tecla enter para fechar.");
        Console.ReadLine();

    }
}
