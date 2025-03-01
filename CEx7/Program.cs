namespace CEx7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor do produto:");
            string[] produtos = { "Arroz", "Feijão", "Macarrão", "Carne", "Frango", "Ovos" };
            double[] precos = { 2.99, 3.99, 1.99, 15.99, 10.99, 5.99 };

            for (int i = 0;  i < produtos.length;  1++)
            {
                Console.WriteLine("O produto mais barato é : + produtos[0] + " e custa: " + precos[0]);
            }
        
        }
    }
}
