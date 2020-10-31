using System;

namespace ByteBank.SistemaInterno
{
    public class ContaPoupanca : Conta
    {
        // Construtor
        public ContaPoupanca(string nome, double cpf, double saldo) : base(nome, cpf, saldo) { }
    }
}
