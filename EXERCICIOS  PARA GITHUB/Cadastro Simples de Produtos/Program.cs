/*
Crie uma classe Produto com propriedades Nome, Preço e Quantidade. Permita ao
usuário cadastrar 3 produtos e depois liste todos com o valor total em estoque (Preço *
Quantidade).
*/

namespace Cadastro_Simples_de_Produtos
{
    class Programa
    {
        public static void Main(string[] args)
        {
            var produtos = new Produto[3];

            for (int i = 0; i < 3; i++)
            {
                // Leitura dos produtos
                string nome;
                double preco;
                int quantidade;

                Console.WriteLine("----------------------------------");
                Console.WriteLine($"PRODUTO {i + 1}");
                Console.Write("Insira o nome do produto: ");
                nome = Console.ReadLine() ?? "";

                Console.Write("Insira o Preço do produto: ");
                preco = double.Parse(Console.ReadLine() ?? "0");

                Console.Write("Insira a quantidade do produto: ");
                quantidade = int.Parse(Console.ReadLine() ?? "0");

                produtos[i] = new Produto(nome, preco, quantidade);
            }

            // Resultado
            for (int i = 0; i < produtos.Length; i++)
            {
                Console.WriteLine($"----- PRODUTO {i + 1} -----");
                Console.WriteLine($"Nome: {produtos[i].Nome}");
                Console.WriteLine($"Preço: {produtos[i].Preco}");
                Console.WriteLine($"Quantidade: {produtos[i].Quantidade}");
                Console.WriteLine($"Valor em estoque: {produtos[i].Preco * produtos[i].Quantidade}");
            }
        }
    }


    class Produto(string Nome, double Preco, int Quantidade)
    {
        public string Nome { get; set; } = Nome;

        public double Preco { get; set; } = Preco;

        public int Quantidade { get; set; } = Quantidade;
    }
}

