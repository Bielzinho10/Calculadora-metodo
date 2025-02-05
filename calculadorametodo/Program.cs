using System.Reflection;
using Calculadora;
 repetir: 
Console.WriteLine("digite o primeiro valor");
if (!decimal.TryParse(Console.ReadLine(),out decimal valorl))
{
    Console.WriteLine("Valor invalido! ");
   goto repetir; 
}
 repetir_valor2: 
Console.WriteLine("digite o segundo valor");
if (!decimal.TryParse(Console.ReadLine(),out decimal valor2))
{
    Console.WriteLine("Valor invalido! ");
   goto repetir_valor2; 
}
    

Operacoes.RalizarAdicao(valorl,valor2);
    
