namespace Layout
{
    public static class Formatacao
    {
        // Método para exibir mensagem com cor
        public static void Cor(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }
    }
}
