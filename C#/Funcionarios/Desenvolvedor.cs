using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        // Construtor
        public Desenvolvedor(double salario) : base(salario) { }


        // Métodos
        public override void AumentarSalario()
        {
            this.Salario = this.Salario + (this.Salario * 0.30);
            Console.WriteLine(this.Nome + " acabou de receber um aumento de salário. (Valor atual: R$" + this.Salario + ")");
        }
    }
}
