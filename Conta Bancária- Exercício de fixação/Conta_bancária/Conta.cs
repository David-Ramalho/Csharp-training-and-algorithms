using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_bancária
{
    internal class Conta
    {
        private string _nome;
        public int NumConta { get; private set; } = 0;        
        public float Saldo { get; private set; }


        /*método get e set para Saldo, porém auto properties é usado!
        public float Saldo1
        {
            get { return Saldo; }
            set
            {
                Saldo = Saldo + value;
            }
        }*/

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
                Saldo = valor;

            }
            else if (String.Equals(Resposta, negativo))
            {
                Console.WriteLine("Valor negativo");
                Saldo = 0;

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
            
            if (NumConta == 0)
            {
                Console.WriteLine("Conta inexistente");
                
            }
            else
            {
                Console.WriteLine(" Qual o valor do deposito");
                float valor = float.Parse(Console.ReadLine());

                if (valor != 0)
                {
                    Saldo = Saldo + valor;
                    //A expressão abaixo seria usada caso o metodo get e set fosse implementado.
                   // Saldo1 = valor;

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
             "\nValor despositado: " + Saldo;
        }

    }
}
