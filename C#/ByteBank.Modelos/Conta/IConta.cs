namespace ByteBank.Modelos.Conta
{
    public interface IConta
    {
        bool VerificarStatusConta();
        void ExibirExtrato();
        void Sacar(double valor);
        void Depositar(double valor);
        void Transferir(double valor, ContaCorrente destino);
    }
}