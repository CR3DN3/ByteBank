using System;

namespace ByteBank.SistemaInterno
{
    public class ContaCorrente : Conta
    {
        // Construtor
        public ContaCorrente(string nome, double cpf, double saldo) : base(nome, cpf, saldo) { }
    }
}
