using System;
using System.Globalization;


namespace EXERCICIOENTRADA {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
                Console.WriteLine("Quantos quartos tem na sua casa?");
            int quarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço do produto:");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu último nome, idade e altura na mesma linha:");
            string[] vet = Console.ReadLine().Split(' ');
            string name = vet[0];
            int old = int.Parse(vet[1]);
            double alt = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine(name);
            Console.WriteLine(old);
            Console.WriteLine(alt.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
