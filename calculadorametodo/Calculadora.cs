namespace Calculadora
{
    public static class Operacoes
    {
        // Método para adição
        public static decimal RealizarAdicao(decimal valor1, decimal valor2)
        {
            return valor1 + valor2;
        }

        // Método para subtração
        public static decimal RealizarSubtracao(decimal valor1, decimal valor2)
        {
            return valor1 - valor2;
        }

        // Método para multiplicação
        public static decimal RealizarMultiplicacao(decimal valor1, decimal valor2)
        {
            return valor1 * valor2;
        }

        // Método para divisão
        public static decimal RealizarDivisao(decimal valor1, decimal valor2)
        {
            if (valor2 == 0)
            {
                throw new DivideByZeroException("Erro: Divisão por zero.");
            }
            return valor1 / valor2;
        }
    }
}
