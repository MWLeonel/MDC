using System;
using System.Diagnostics;

namespace MDC
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2;
            int divisor, dividendo, resto;
            bool v1Valido, v2Valido;
            string op;

            do
            {
                Console.Write("Digite o 1ºValor(a): ");
                v1Valido = int.TryParse(Console.ReadLine(), out valor1);

                if (!v1Valido)
                {
                    Console.WriteLine();
                    Console.WriteLine("Você digitou um valor invalido!");
                    Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente");
                    Console.ReadKey();
                    Environment.Exit(-1);
                }

                Console.Write("Digite o 2ºValor(b): ");
                v2Valido = int.TryParse(Console.ReadLine(), out valor2);

                if (!v2Valido)
                {
                    Console.WriteLine();
                    Console.WriteLine("Você digitou um valor invalido!");
                    Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente");
                    Console.ReadKey();
                    Environment.Exit(-1);
                }

                if (valor1 == 0 || valor2 == 0)
                {
                    Console.WriteLine("Não pode conter valores que são igual a zero");
                }

                if (valor1 > valor2)
                {
                    dividendo = valor1;
                    divisor = valor2;
                }

                else
                {
                    dividendo = valor2;
                    divisor = valor1;
                }
                while (dividendo % divisor != 0)
                {
                    resto = dividendo % divisor;
                    dividendo = divisor;
                    divisor = resto;
                }

                Console.WriteLine();
                Console.WriteLine("MDC(a, b) = " + divisor);

                Console.WriteLine("Deseja Sair? S/N");
                op = Console.ReadLine().ToUpper();
            }
            while (op == "N" || op == "NAO"); 
            {
                Console.WriteLine();
                Console.WriteLine("Obrigado por utilizar meu programa!");
                Environment.Exit(-1);
            }
        }
    }
}
