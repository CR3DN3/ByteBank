using System;

namespace ByteBank.Funcionario
{
    public class Gerente : Funcionario
    {
        // Construtor
        public Gerente(string titular, int numero, double agencia, double saldo, bool statusConta) : base(titular,
            numero, agencia, saldo, statusConta)
        {
            Cargo = "Gerente";
            Salario = 10000;
        }

        
        // Métodos
        public override void ReceberSalario()
        {
            Depositar(Salario);
            Console.WriteLine("Salário depositado com sucesso!");
        }

        public override void ReceberBonificacao()
        {
            double bonificacao = Salario * 0.15;
            Depositar(bonificacao);
            Console.WriteLine($"Bonificação no valor de R${bonificacao} recebida!");
        }
    }
}