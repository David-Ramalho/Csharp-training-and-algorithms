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

            Conta Cadastro= new Conta();

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
                    Console.WriteLine("Abrindo");
                    Cadastro.AbrirConta(); 
                    Console.Clear();
                    Console.WriteLine(Cadastro);
                    Console.ReadKey();
                }
                else if (i == 2)
                {
                    Console.Clear();
                    Console.WriteLine("                  ***Welcome to the account bank program*** ");
                    Console.WriteLine("Sacando");                    
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