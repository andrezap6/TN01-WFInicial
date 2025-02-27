namespace ConsoleRevisaoAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a 1 primeira Nota do Aluno!");
            double nota = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a 2 primeira Nota do Aluno!");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            double media = (nota + nota2) / 2;

            if (media >= 7)
            {
                Console.WriteLine("Aprovado!");
            }
            else if (media < 5)
            {
                Console.WriteLine("Reprovado!");
            }
            else
            {
                Console.WriteLine("Recuperação!");
            }
        }
    }
}
