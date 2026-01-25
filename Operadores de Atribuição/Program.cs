namespace Operadores_de_Atribuicao;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("============Operadores de Atribuição============");

        //Inicializar a variavel
        int x = 10;
        Console.WriteLine("\nValor Inicial da Variável de x: " + x);

        //Atribuição Simples (=)
        x = 20;
        Console.WriteLine("\nAtribuição Simples (=)");
        Console.WriteLine("Valor de x: " + x);

        //Atribuição Composta (Incremento) (++)
        x++;  //Equivale a    x = x + 1
            Console.WriteLine("\nAtribuição Composta Incremento (++)");
            Console.WriteLine("Novo Valor de X:  " + x);

        //Atribuição Composta (+=)
        x += 10; //Equivale a   x = x + 10
        Console.WriteLine("\nAtribuição Composta Incremento (+=)");
        Console.WriteLine("Novo Valor de X:  " + x);

        //Atribuição Composta (-=)
        x -= 10; //Equivale a   x = x - 10
        Console.WriteLine("\nAtribuição Composta Incremento (-=)");
        Console.WriteLine("Novo Valor de X:  " + x);

        //Atribuição Composta (*=)
        x *= 10; //Equivale a   x = x * 10
        Console.WriteLine("\nAtribuição Composta Incremento (*=)");
        Console.WriteLine("Novo Valor de X:  " + x);

        //Atribuição Composta (/=)
        x /= 10; //Equivale a   x = x * 10
        Console.WriteLine("\nAtribuição Composta Incremento (/=)");
        Console.WriteLine("Novo Valor de X:  " + x);
    }

}