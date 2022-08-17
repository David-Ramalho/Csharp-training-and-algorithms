using Conta_bancária;
using System;
using System.Globalization;
using System.Threading;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = -1;

            Conta Cadastro = new Conta();
            float valor = 0;

            //Menu principal
            while (i != 0)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the account bank program");

                Console.WriteLine("Selecione alguma opção:");
                Console.WriteLine(" ");
                Console.WriteLine("1-Abrir conta\n2-Sacar\n3-Depositar\n0-Sair");
                i = int.Parse(Console.ReadLine());

                //opções selecionadas do menú:
                if (i == 1)
                {
                    Console.Clear();
                    Console.WriteLine("                  ***Welcome to the account bank program*** ");
                    Console.WriteLine("Digite o nome completo por gentileza: ");
                    string titular = Console.ReadLine();

                    Console.WriteLine("Desejas depositar um valor inicial? 'S' ou 'N' ");
                    char Resposta = char.Parse(Console.ReadLine().ToLower());
                    char positivo = 's';
                    char negativo = 'n';

                    if (String.Equals(Resposta, positivo))
                    {
                        //Não é mais usado, pois foi implementado outro método!

                        /*Console.WriteLine("Valor positivo");
                        Console.WriteLine("Qual o valor do deposito?");
                        valor = float.Parse(Console.ReadLine());  
                        */
                        Cadastro = new Conta(titular, valor);

                    }
                    else if (String.Equals(Resposta, negativo))
                    {
                        Console.WriteLine("Valor negativo");
                        valor = 0;
                        Cadastro = new Conta(titular);
                        Thread.Sleep(1000);

                    }
                    else
                    {
                        Console.WriteLine("Valor incorreto! tente novamente");
                    }
                    Console.Clear();
                    Console.WriteLine("Gerando número de conta! Um momento por gentileza");
                    Thread.Sleep(5000);


                    Console.Clear();
                    Console.WriteLine(Cadastro);
                    Console.ReadKey();
                }
                else if (i == 2)
                {
                    Console.Clear();
                    Console.WriteLine("                  ***Welcome to the account bank program*** ");

                    if (Cadastro.NumConta == 0)
                    {
                        Console.WriteLine("Conta inexistente");

                    }
                    else
                    {
                        Console.WriteLine("\nSaldo Atual: ");
                        Console.WriteLine(Cadastro.Saldo);
                        Cadastro.Sacar();

                        Console.Clear();
                        Console.WriteLine("\nSaldo Atual: ");
                        Console.WriteLine(Cadastro.Saldo);

                    }
                    Console.ReadKey();
                }
                else if (i == 3)
                {
                    Console.Clear();
                    Console.WriteLine("                  ***Welcome to the account bank program*** ");
                    Console.WriteLine("Depositando");
                    Cadastro.Depositar();
                    if (Cadastro.Saldo != 0)
                    {
                        Console.WriteLine("\nAtualizando Saldo ");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine(" ");
                        Console.WriteLine("Deposito realizado!\nSaldo atual: ");
                        Console.WriteLine(Cadastro.Saldo);
                    }

                    Console.ReadKey();
                }
                else if (i == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Exiting");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Comando inválido! Tente novamente!!");
                    //Thread.Sleep(3000);
                    //Console.Clear();
                    Console.ReadKey();
                }

            }
        }
    }
}