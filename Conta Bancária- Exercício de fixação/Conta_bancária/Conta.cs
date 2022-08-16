using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_bancária
{
    internal class Conta
    {
        public int NumConta { get; private set; } = 0;
        private string _nome;
        private float _saldo;

        
        public void AbrirConta()
        {
            Console.Clear();
            Console.WriteLine("                  ***Welcome to the account bank program*** ");
            Console.WriteLine(" ");

            Console.WriteLine("Digite o nome completo por gentileza: ");
            _nome = Console.ReadLine();
            Console.WriteLine("Desejas depositar um valor inicial? 'sim' ou 'nao' ");
            string Resposta = Console.ReadLine().ToLower();
            string positivo = "sim";
            string negativo = "nao";

            if (String.Equals(Resposta, positivo))
            {
                Console.WriteLine("Valor positivo");
                Console.WriteLine("Qual o valor do deposito?");
                float valor = float.Parse(Console.ReadLine());
                _saldo = valor;

            }
            else if (String.Equals(Resposta, negativo))
            {
                Console.WriteLine("Valor negativo");
                _saldo = 0;

            }
            else
            {
                Console.WriteLine("Valor incorreto! tente novamente");
            }

            Console.WriteLine("Gerando número de conta! Um momento por gentileza");
            Random numAleatorio = new Random();
            NumConta = numAleatorio.Next();
            Thread.Sleep(5000);



        }

        public void Depositar()
        {
            Console.Clear();
            Console.WriteLine("                  ***Welcome to the account bank program*** ");
            Console.WriteLine(" Qual o valor do deposito");
            float valor = float.Parse(Console.ReadLine());

            if (NumConta == 0)
            {
                Console.WriteLine("Conta inexistente");
            }
            else
            {
                if (valor != 0)
                {
                    _saldo = _saldo + valor;
                    Console.WriteLine("Deposito realizado!\n Saldo atual: ", _saldo);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Valor inválido!!");
                }
            }
        }

        //formatação
        public override string ToString()
        {
            return
            "Nome do titular: " + _nome +
            " " +
             "\nNúmero de conta: " + NumConta +
             " " +
             "\nValor despositado: " + _saldo;
        }

    }
}
