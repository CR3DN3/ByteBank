using System;

namespace ByteBank.Modelos.Conta
{
    public abstract class ContaCorrente : IConta
    {
        // Getters & Setters
        public string Titular { get; }
        public int Numero { get; }
        public double Agencia { get; }
        public double Saldo { get; set; }
        public bool StatusConta { get; }
        
        
        protected ContaCorrente(string titular, int numero, double agencia, double saldo, bool statusConta)
        {
            Titular = titular;
            Numero = numero;
            Agencia = agencia;
            Saldo = saldo;
            StatusConta = statusConta;
        }

        // Métodos
        public bool VerificarStatusConta() { return StatusConta; }

        public virtual void ExibirExtrato()
        {
            Console.WriteLine("|======| Extrato da Conta: |======|");
            Console.WriteLine($"Titular: {Titular}");
            Console.WriteLine($"Numero da conta: {Numero}");
            Console.WriteLine($"Agencia: {Agencia}");
            Console.WriteLine($"Saldo Total: R${Saldo}");
            Console.WriteLine(StatusConta ? $"Status da conta: Ativa\n" : $"Status da conta: Desativada\n");
        }

        public void Sacar(double valor)
        {
            if (StatusConta)
            {
                if (Saldo < valor)
                {
                    Saldo -= valor;
                    Console.WriteLine($"Saque realizado com sucesso no valor de R${valor}\n");
                }
                else
                {
                    Console.WriteLine($"Não foi possível realizar o saque no valor de R${valor}."); 
                    Console.WriteLine("Saldo insuficiente.\n");
                }
            }
            else
            {
                Console.WriteLine("A conta infelizmente encontra-se desativada.");
            }

        }

        public virtual void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Deposito realizado com sucesso no valor de R${valor}.");
        }

        public void Transferir(double valor, ContaCorrente destino)
        {
            if (Saldo > valor)
            {
                Saldo -= valor;
                destino.Saldo += valor;
                Console.WriteLine($"Transferência realizada com sucesso no valor de R${valor}\n");
            }
            else
            {
                Console.WriteLine($"Não foi possível realizar a transferência no valor de R${valor}.");
                Console.WriteLine("Saldo insuficiente.\n"); 
            }
        }
    }
}