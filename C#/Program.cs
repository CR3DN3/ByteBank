using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação de Objetos
            Gerente carlos = new Gerente(4000);
            carlos.Nome = "Carlos Alberto de Nóbrega";

            Desenvolvedor marcio = new Desenvolvedor(6000);
            marcio.Nome = "Márcio Santos";


            // Ações de Métodos
            carlos.Depositar(5000);
            Console.WriteLine(carlos.Saldo);

            
            carlos.Transferir(300, marcio);
            Console.WriteLine(marcio.Saldo);






            // Finalização
            Console.ReadLine();
        }
    }
}
