using System;

namespace ByteBank.Funcionarios
{
    public class Gerente : Funcionario
    {
        // Construtor
        public Gerente(string nome, double cpf, double saldo) : base(nome, cpf, saldo)
        {
            Profissao = "Gerente";
            Salario = 10000;
        }


        // Métodos
        public override void ReceberSalario()
        {
            Saldo += Salario;
            Console.WriteLine(Nome + " salário recebido. Valor: R$" + Salario);
        }

        public override void ReceberAumento()
        {
            Salario += (Salario * 0.15);
            Console.WriteLine(Nome + " aumento recebido de 15%. Salário atual: R$" + Salario);
        }
    }
}
