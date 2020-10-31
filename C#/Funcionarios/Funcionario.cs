using System;
using ByteBank.SistemaInterno;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario : Conta
    {
        // Atributos (Getters e Setters)
        public string Profissao { get; set; }
        public double Salario { get; set; }

        // Construtor
        protected Funcionario(string nome, double cpf, double saldo) : base(nome, cpf, saldo) { }


        // Métodos
        public override void Extrato()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("CPF: " + Cpf);
            Console.WriteLine("Saldo: " + Saldo);
            Console.WriteLine("Salário: " + Salario);
        }

        public abstract void ReceberSalario();
        public abstract void ReceberAumento();
    }
}
