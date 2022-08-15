using System.Globalization;
namespace Course
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        //Construtor padrão
        public Produto(){ Quantidade = 0; }

        // Construtor e this.
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {            
            Quantidade = quantidade;
        }

        // sobreCarga e this
        public Produto(string Nome, double Preco)
        {   
            this.Nome = Nome;
            this.Preco = Preco;
            
            //Quantidade = 0;
        }



        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}