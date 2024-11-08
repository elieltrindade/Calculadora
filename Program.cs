using System;                   //biblioteca básica do dotnet
using System.Diagnostics;

namespace Calculadora           //divisão lógica 
{
    class Program               //
    {
        static void Main(string[] args)                             //método principal
        {
            // Soma();
            // Subtracao();
            // Divisao();
            // Multiplicacao();
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("---------------");
            Console.Write("Digite o número da opção desejada: ");
            short opcaoMenu = short.Parse(Console.ReadLine());                  //short - menor tipo inteiro 

            switch (opcaoMenu)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;                      //comando para sair do sistema
                default: Menu(); break;
            }

        }

        static void Soma()
        {
            Console.Clear();                                        //para limpar o console

            Console.Write("Primeiro valor: ");                    //Console.Write ou Console.Write - mostar um texto para o usuário
            double parcela1 = double.Parse(Console.ReadLine());     //armazena o valor inserido pelo usuário, que foi convertido para double

            Console.Write("Segundo valor: ");
            double parcela2 = double.Parse(Console.ReadLine());

            double resultado = parcela1 + parcela2;

            Console.WriteLine("");

            //Forma de Conatenar valores 
            // Console.WriteLine("A soma dos valores é " + resultado);
            Console.WriteLine($"A soma dos valores é {resultado}");
            // Console.WriteLine($"A soma dos valores é {parcela1 + parcela2}");
            // Console.WriteLine("A soma dos valores é " + (parcela1 + parcela2));

            Console.ReadKey();              //espera que o usuário pressione uma tecla antes de continuar a execução do programa
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            double parcela1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double parcela2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = parcela1 - parcela2;
            Console.WriteLine($"O resultado é: {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            double parcela1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double parcela2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = parcela1 / parcela2;
            Console.WriteLine($"O resultado é {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            double parcela1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double parcela2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = parcela1 * parcela2;
            Console.WriteLine($"O resultado é {resultado}");
            Menu();
        }

    }
}
