using System;
using System.IO.Pipes;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 12 - Encadeando For");

        //*
        //**
        //***
        //****
        //*****

        // Com break
        for (int contatorLinhas = 0; contatorLinhas < 10; contatorLinhas++)
        {
            for (int contatorColunas = 0; contatorColunas < 10; contatorColunas++)
            {
                Console.Write("*");
                if (contatorColunas >= contatorLinhas)
                    break;
            }
            Console.WriteLine();
        }

        // Sem break
        for (int contatorLinhas = 0; contatorLinhas < 10; contatorLinhas++)
        {
            for (int contatorColunas = 0; contatorColunas <= contatorLinhas; contatorColunas++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Tecle enter para fechar.");
        Console.ReadLine();
    }
}