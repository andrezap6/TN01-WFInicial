namespace CEx4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o 1º número: ");
            int num1 = int.Parse(Console.ReadLine()!);
            Console.Write("\n Digite o 2º número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o 3º número: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int maior = Math.Max(num1, num2);
            maior = Math.Max(maior, num3);

            Console.WriteLine($"\n O maior número é: {maior}");
        }
    }
}
