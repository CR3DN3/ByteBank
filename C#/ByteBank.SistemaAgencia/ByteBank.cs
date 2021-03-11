using System;
using ByteBank.Modelos.Conta;
using ByteBank.Modelos.Funcionario;

namespace ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Inicialização
            Console.WriteLine("\n|==========| Bem-vindo ao ByteBank! |==========|\n");
            
            // Objetos
            ContaPoupanca contaJoao = new ContaPoupanca("João Soares Neto", 123456, 7, 500, true);
            Atendente contaCarlos = new Atendente("Carlos Magalhães", 123475, 7, 0, true);

            // Escopo
            contaJoao.ExibirExtrato();
            contaCarlos.ExibirExtrato();

            // Finalização
            Console.ReadLine();
        }
    }
}