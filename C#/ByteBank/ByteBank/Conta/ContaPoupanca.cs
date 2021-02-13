using System;

namespace ByteBank.Conta
{
    public class ContaPoupanca : ContaCorrente
    {
        // Construtor
        public ContaPoupanca(string titular, int numero, double agencia, double saldo, bool statusConta) : base(titular, 
            numero, agencia, saldo, statusConta) { }
        
        // Métodos
        public override void Depositar(double valor)
        {
            Saldo += valor + (valor * 0.005);
            Console.WriteLine($"\nDeposito realizado com sucesso no valor de R${valor}.");
        }
    }
}