using System.Globalization;
namespace Course
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; } //auto proper
        public int Quantidade { get; private set; } //auto proper

        //Construtor padrão
        public Produto() { }

        // Construtor 
        public Produto(string nome, double preco, int quantidade) 
        {
            Quantidade = quantidade;
            _nome = nome;
            Preco = preco;
        }

        // encapsulamento, porém irei usar o método de properties
       /* public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if(nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }
       */

        //properties, irei usar auto properties para os outros atributos.
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            if (quantidade >= 1)
            {
                Quantidade += quantidade;
            }
            else
            {
                Console.WriteLine("Quantidade inválida");
                Console.ReadKey();


            }

        }

        public void SetAdicionarProdutos(int quantidade)
        {
            if (quantidade >= 1)
            {
                Quantidade += quantidade;
            }
            else
            {
                Console.WriteLine("Quantidade inválida");
                Console.ReadKey();

            }

        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}