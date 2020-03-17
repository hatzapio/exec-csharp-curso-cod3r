using System;

namespace CursoCSharp.Fundamentos
{
    public class VariavesEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 4.14;

            raio = 5.5;
//            PI = 3.1415;
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Area é " + area);

            string nome = "Notebook Gamer";
            var marca = "Dell";
            double preco = 5_800.90;
            Console.WriteLine("O " + nome + " da marca " + marca + " custa R$ " + preco);
            Console.WriteLine("O {0} da marca {1} custa R$ {2}.", nome, marca, preco);
            Console.WriteLine($"O {nome} da marca {marca} custa R$ {preco}.");
        }
    }
}