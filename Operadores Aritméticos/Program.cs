using System.Runtime.CompilerServices;

namespace Operadores_Aritmeticos;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===============CALCULADORA BEM SIMPLES DE 2 VALORES===============");
        Console.WriteLine("Digite o Número 1: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o Número 2: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // SOMA
        int sum = number1 + number2;
        Console.WriteLine("O Valor da Some é: " + sum);

        // SUBTRAÇÃO
        int subbtraction = number1 - number2;
        Console.WriteLine("O Valor da Subtração é: " + subbtraction);

        //MULTIPLICAÇÃO
        int multiplicattion = number1 * number2;    
        Console.WriteLine("O Valor da Multiplicação é: " + multiplicattion);

        //DIVISÃO
        int division = number1 / number2;
        Console.WriteLine("O Valor da Divisão é: " + division);
    }
}