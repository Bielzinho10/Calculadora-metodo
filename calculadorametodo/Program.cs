using System;
using Calculadora;  // Usando a classe Calculadora
using Layout;       // Usando a classe de Layout para formatação

class Program
{
    static void Main()
    {
        decimal valor1, valor2;

        // Repetir até o usuário digitar um valor válido para o primeiro número
        while (true)
        {
            Formatacao.Cor("Digite o primeiro valor: ", ConsoleColor.Blue);
            if (!decimal.TryParse(Console.ReadLine(), out valor1))
            {
                Console.WriteLine("Valor inválido! ");
                continue; // Continua o loop se o valor for inválido
            }
            break; // Sai do loop se o valor for válido
        }

        // Repetir até o usuário digitar um valor válido para o segundo número
        while (true)
        {
            Formatacao.Cor("Digite o segundo valor: ", ConsoleColor.Yellow);
            if (!decimal.TryParse(Console.ReadLine(), out valor2))
            {
                Console.WriteLine("Valor inválido! ");
                continue; // Continua o loop se o valor for inválido
            }
            break; // Sai do loop se o valor for válido
        }

        // Menu de operações
        Formatacao.Cor("Escolha a operação: ", ConsoleColor.Cyan);
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        int escolha = int.Parse(Console.ReadLine());

        decimal resultado = 0;

        switch (escolha)
        {
            case 1:
                resultado = Operacoes.RealizarAdicao(valor1, valor2);
                break;
            case 2:
                resultado = Operacoes.RealizarSubtracao(valor1, valor2);
                break;
            case 3:
                resultado = Operacoes.RealizarMultiplicacao(valor1, valor2);
                break;
            case 4:
                if (valor2 != 0)
                {
                    resultado = Operacoes.RealizarDivisao(valor1, valor2);
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não permitida.");
                    return; // Interrompe o programa
                }
                break;
            default:
                Console.WriteLine("Opção inválida!");
                return;
        }

        // Mostrar o resultado
        Console.WriteLine($"Resultado: {resultado}");
        Console.WriteLine("Operação finalizada.");
    }
}
