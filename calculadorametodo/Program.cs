using System.Reflection;
using Calculadora;
using Layout;
repetir: 

Formatacao.Cor("Digite o primeiro valor: ", ConsoleColor.Blue);
if (!decimal.TryParse(Console.ReadLine(),out decimal valorl))
{
    Console.WriteLine("Valor invalido! ");
   goto repetir; 
}
 repetir_valor2: 
10
Formatacao.Cor("Digite o segundo valor: ", ConsoleColor.Yellow);
if (!decimal.TryParse(Console.ReadLine(),out decimal valor2))
{
    Console.WriteLine("Valor invalido! ");
   goto repetir_valor2; 
}
    

Operacoes.RalizarAdicao(valorl,valor2);
    
