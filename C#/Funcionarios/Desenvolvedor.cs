using System;

namespace ByteBank.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        // Construtor
        public Desenvolvedor(string nome, double cpf, double saldo) : base(nome, cpf, saldo)
        {
            Profissao = "Desenvolvedor";
            Salario = 15000;
        }


        // Métodos
        public override void ReceberSalario()
        {
            Saldo += Salario;
            Console.WriteLine(Nome + " salário recebido. Valor: R$" + Salario);
        }

        public override void ReceberAumento()
        {
            Salario += (Salario * 0.25);
            Console.WriteLine(Nome + " aumento recebido de 25%. Salário atual: R$" + Salario);
        }
    }
}