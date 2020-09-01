using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistema
{
    public class ContaCorrente
    {
        // Getters e Setters
        public string Nome { get; set; }
        public double CPF { get; set; }
        public double NumeroDaConta { get; set; }
        public double Saldo { get; set; }


        // Métodos
        public void Depositar(double valor)
        {
            this.Saldo += valor;
            Console.WriteLine("O valor de R$" + valor + " foi depositado.");
        }

        public void Sacar(double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                Console.WriteLine("O valor de R$" + valor + " foi sacado.");
            }
            else
            {
                Console.WriteLine("Não foi possível realizar o saque no valor de R$" + valor);
            }
        }

        public void Transferir(double valor, ContaCorrente destino)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                destino.Saldo += valor;
                Console.WriteLine("O valor de R$" + valor + " foi transferido para " + destino.Nome);
            }
            else
            {
                Console.WriteLine("Não foi possível realizar a transferência.");
            }
        }
    }
}
