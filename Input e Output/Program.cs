namespace Input_Output;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("---------CADASTRO DE USUÁRIOS---------");
    
    // Solicita o nome do usuário
        Console.Write("Digite seu nome: ");
        string name = Console.ReadLine();

    // Solicita a idade do usuario
        Console.Write("Digite Sua Idade: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("-----------------------------------");

        Console.WriteLine("Nome do Usuário Cadastrado com sucesso: " + name);
        Console.WriteLine("Idade do Usuário Cadastrado com sucesso: " + age);
    }
}