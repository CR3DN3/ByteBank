using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class ByteBank
    {
        static void Main()
        {
            // Escopo
            Gerente julio = new Gerente("Julio Cesar Campos", 37374758691, 0);
            Desenvolvedor carlos = new Desenvolvedor("Carlos Andrade Silva", 842131231232, 0);


            julio.Extrato();
            Console.WriteLine("\n");
            carlos.Extrato();


            Console.WriteLine("\n");

            julio.ReceberSalario();
            julio.ReceberAumento();

            Console.WriteLine("\n");

            julio.Extrato();
            Console.WriteLine("\n");
            carlos.Extrato();



            // Exit
            Console.ReadLine();
        }
    }
}
