namespace CEx6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o seu nome: ");  
            string nome = Console.ReadLine()!;
            Console.Write("\nInforme o valor da hora: ");
            int quantidadeHoras = int.Parse(Console.ReadLine()!);
            Console.Write("\nInforme o valor da hora: ");
            double valorHora = Convert.ToDouble(Console.ReadLine());

            double resultado = valorHora * quantidadeHoras;

            Console.WriteLine($"A renda total de {nome} é R$ {resultado:F2}");

        }
    }
}
