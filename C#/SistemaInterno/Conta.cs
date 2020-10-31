using System;

namespace ByteBank.SistemaInterno
{
    public abstract class Conta
    {
        // Atributos (Getters e Setters)
        public string Nome { get; set; }
        public double Cpf { get; set; }
        public double Saldo { get; set; }


        // Método Construtor
        protected Conta(string nome, double cpf, double saldo)
        {
            Nome = nome;
            Cpf = cpf;
            Saldo = saldo;
        }


        // Métodos
        public virtual void Extrato()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("CPF: " + Cpf);
            Console.WriteLine("Saldo: " + Saldo);
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine(Nome + " o deposito foi efetuado com sucesso! Valor: R$" + valor);
        }

        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine(Nome + " o saque foi efetuado com sucesso! Valor: R$" + valor);
            }
            else
            {
                Console.WriteLine("O saque não pode ser efetuado.");
            }
        }

        public void Transferir(double valor, Conta destino)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                destino.Saldo += valor;
                Console.WriteLine(Nome + " a transferência foi efetuada com sucesso! Valor: R$" + valor + " para " + destino.Nome);
            }
            else
            {
                Console.WriteLine("A transferência não pode ser efetuada.");
            }
        }

    }
}
