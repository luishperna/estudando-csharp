using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 4664.00;

        if (salario >= 1900.0 && salario <= 2800.0)
        {
            int valorParaReduzir = 142;
            double salarioReduzido = salario - valorParaReduzir;
            Console.WriteLine("IR DE 7.5% - Redução de 142 reais");
            Console.WriteLine("Salário deduzido para: R$" + salarioReduzido);
        }

        if (salario >= 2800.01 && salario <= 3751.0)
        {
            int valorParaReduzir = 350;
            double salarioReduzido = salario - valorParaReduzir;
            Console.WriteLine("IR DE 15% - Redução de 350 reais");
            Console.WriteLine("Salário deduzido para: R$" + salarioReduzido);
        }

        if (salario >= 3751.01 && salario <= 4664.00)
        {
            int valorParaReduzir = 636;
            double salarioReduzido = salario - valorParaReduzir;
            Console.WriteLine("IR DE 22.5% - Redução de 636 reais");
            Console.WriteLine("Salário deduzido para: R$" + salarioReduzido);
        }
    }
}