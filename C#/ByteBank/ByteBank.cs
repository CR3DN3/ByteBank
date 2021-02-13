using System;
using ByteBank.Conta;
using ByteBank.Funcionario;

namespace ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n|==========| Bem-vindo ao ByteBank! |==========|\n");
            
            // Objetos
            Gerente contaJoao = new Gerente("João Soares Neto", 123456, 7, 500, true);
            Programador contaCarlos = new Programador("Carlos Magalhães Silveira", 123475, 7, 0, true);

            // Escopo
            contaJoao.ExibirExtrato();
            contaCarlos.ExibirExtrato();
            
            Console.WriteLine("\n==============================================");
            
            contaCarlos.ReceberSalario();
            contaJoao.ReceberSalario();
            
            Console.WriteLine("==============================================\n");
            
            contaCarlos.Transferir(10000, contaJoao);
            
            Console.WriteLine("==============================================\n");
            
            contaJoao.ExibirExtrato();
            contaCarlos.ExibirExtrato();
            
        }
    }
}