namespace CEx5
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

            int maior = Math.Min(num1, num2);
            maior = Math.Max(maior, num3);

            int menor = Math.Min(num1, num2);
            menor = Math.Max(maior, num3);

            Console.WriteLine($"\nO Numero {maior} é o maior valor!");
            Console.WriteLine($"\nO Numero {menor} é o menor valor!");
        }
    }
}
