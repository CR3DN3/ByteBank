using System;
using ByteBank.Conta;

namespace ByteBank.Funcionario
{
    public abstract class Funcionario : ContaPoupanca, IFuncionario
    {
        // Getters & Setters
        public string Cargo { get; set; }
        public double Salario { get; set; }

        // Construtor
        protected Funcionario(string titular, int numero, double agencia, double saldo, bool statusConta) : 
            base(titular, numero, agencia, saldo, statusConta) { }
        
        // Métodos
        public override void ExibirExtrato()
        {
            Console.WriteLine("|======| Extrato da Conta: |======|");
            Console.WriteLine($"Titular: {Titular}");
            Console.WriteLine($"Numero da conta: {Numero}");
            Console.WriteLine($"Agencia: {Agencia}");
            Console.WriteLine($"Saldo Total: R${Saldo}");
            Console.WriteLine(StatusConta ? $"Status da conta: Ativa\n" : $"Status da conta: Desativada\n");
            
            Console.WriteLine("|======| Informações do funcionário: |======|");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salário: R${Salario}\n");
        }


        // Métodos abstratos.
        public abstract void ReceberSalario();
        public abstract void ReceberBonificacao();
    }
}