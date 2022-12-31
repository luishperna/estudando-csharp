using System;

class Programa
{
    static void Main(string[] args)
    {
        for (int numero = 1; numero <= 100; numero++)
        {
            if (numero % 3 == 0)
            {
                Console.WriteLine("o seguinte número é múltiplo de 3: {0,15}", numero);
            }
        }
    }
}
