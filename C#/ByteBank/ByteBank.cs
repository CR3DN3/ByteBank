using System;
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
            Atendente contaCarlos = new Atendente("Carlos Magalhães", 123475, 7, 0, true);

            // Escopo
            contaJoao.ExibirExtrato();
            contaCarlos.ExibirExtrato();
        }
    }
}