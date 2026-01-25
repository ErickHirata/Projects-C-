namespace Estrutura_Condicional_If_Else;

public class Program
{
   public static void Main()
   {
        Console.WriteLine("=============Verificador de Números Pares ou Ímpares=============");
        Console.WriteLine("Digite um Número: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = number % 2;
        if (result == 0)
        { 
            Console.WriteLine("O Número digitado é PAR!");
        }
            else 
            { 
            Console.WriteLine("O Número digitado é IMPAR!");
            }
    }
}
