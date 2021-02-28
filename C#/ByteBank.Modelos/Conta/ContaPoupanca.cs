using System;

namespace ByteBank.Modelos.Conta
{
    
    /// <summary>
    /// Define uma Conta Poupança do banco ByteBank.
    /// </summary>
    public class ContaPoupanca : ContaCorrente
    {
        // Construtor
        /// <summary>
        /// Cria uma instância da <see cref="ContaPoupanca"/> com os argumentos utilizados.
        /// </summary>
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