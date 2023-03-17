namespace Diamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            bool par = true;

            // Input de dados
            Console.WriteLine("-------- Diamante --------");
            Console.WriteLine();

            Console.WriteLine(">> Digite um número ímpar para formar um diamante: ");
            Console.Write(">> ");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Validação de número ímpar
            do
            {
                if (input % 2 == 0)
                {
                    Console.Clear();
                    Console.WriteLine("-------- Diamante --------");
                    Console.WriteLine();
                    Console.WriteLine($">> {input} é um número par, digite um número ímpar!");
                    Console.Write(">> ");
                    input = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }
                else
                {
                    par = false;
                }
            }

            while (par == true);

            for (int i = 0; i < input; i++)
            {
                if (i <= input / 2)
                {
                    Console.WriteLine(new string(' ', input / 2 - i) + new string('x', 2 * i + 1));
                }
                else
                {
                    Console.WriteLine(new string(' ', i - input / 2) + new string('x', 2 * (input - i) - 1));
                }
            }
        }
    }
}