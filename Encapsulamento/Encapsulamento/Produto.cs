using System.Globalization;
namespace Course
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        //Construtor padrão
        public Produto() { }

        // Construtor 
        public Produto(string nome, double preco, int quantidade) 
        {
            _quantidade = quantidade;
            _nome = nome;
            _preco = preco;
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

        //properties
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
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            if (quantidade >= 1)
            {
                _quantidade += quantidade;
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
                _quantidade += quantidade;
            }
            else
            {
                Console.WriteLine("Quantidade inválida");
                Console.ReadKey();

            }

        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}