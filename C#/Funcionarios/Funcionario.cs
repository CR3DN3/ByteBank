using ByteBank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario : ContaCorrente
    {
        // Getters e Setters
        public double Salario { get; protected set; }
        public bool Demitido { get; set; }
        public static int IdCargo { get; protected set; }


        // Construtor
        public Funcionario(double salario)
        {
            this.Salario = salario;
            IdCargo++;
        }

        // Métodos
        public abstract void AumentarSalario();


        public void ObterSalario()
        {
            Console.WriteLine(this.Nome + " tem um salário atual de R$" + this.Salario);
        }

        public virtual bool Demitir()
        {
            Console.WriteLine(this.Nome + " acaba de ser demitido.");
            this.Demitido = true;
            return this.Demitido;
        }
    }
}
