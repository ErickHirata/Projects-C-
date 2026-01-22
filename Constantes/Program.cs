namespace ProjetoVariaveis
{
    class Program
    {
        public static void Main()
        {
            int Number = 30;
            Number = 20;
            Console.WriteLine("O Antigo Valor da variável era: " + Number);

            Number = 10;
            Console.WriteLine("O Novo Valor da variável é: " + Number);

            string name = "Erick";
            Console.WriteLine("O Nome era: " + name);

            name = "João";
            Console.WriteLine("O Novo Nome é: " + name);
        }
    }
}