using System;

namespace ByteBank.Funcionario
{
    public class Programador : Funcionario
    {
        public Programador(string titular, int numero, double agencia, double saldo, bool statusConta) : base(titular, 
            numero, agencia, saldo, statusConta)
        {
            Cargo = "Programdor";
            Salario = 15000;
        }

        
        // Métodos
        public override void ReceberSalario()
        {
            Depositar(Salario);
            Console.WriteLine("Salário depositado com sucesso!");
        }

        public override void ReceberBonificacao()
        {
            double bonificacao = Salario * 0.25;
            Depositar(bonificacao);
            Console.WriteLine($"Bonificação no valor de R${bonificacao} recebida!");
        }
    }
}