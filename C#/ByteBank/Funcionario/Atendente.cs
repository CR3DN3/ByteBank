using System;

namespace ByteBank.Funcionario
{
    public class Atendente : Funcionario
    {
        // Construtor
        public Atendente(string titular, int numero, double agencia, double saldo, bool statusConta) : base(titular, 
            numero, agencia, saldo, statusConta)
        {
            Cargo = "Atendente";
            Salario = 2400;
        }

        
        // Métodos
        public override void ReceberSalario()
        {
            Depositar(Salario);
            Console.WriteLine("Salário depositado com sucesso!");
        }

        public override void ReceberBonificacao()
        {
            double bonificacao = Salario * 0.05;
            Depositar(bonificacao);
            Console.WriteLine($"Bonificação no valor de R${bonificacao} recebida!");
        }
    }
}