public class Conta{

    // Atributos
    private Cliente titular;
    private int id;
    private double saldo;

    // Métodos
    public void depositar(double valor) {
        this.saldo += valor;
        System.out.println("Foi depositado um valor de R$" + valor);
    }

    public void transferir(double valor, Cliente destino) {
        this.saldo -= valor;
        destino.setSaldo(valor);
        System.out.println("O valor de R$" + valor + " foi transferido para " + destino.getNome());
    }

    public void sacar(double valor) {
        this.saldo -= valor;
    }


    // Getters e Setters
    public Cliente getTitular() {
        return titular;
    }

    public void setTitular(Cliente titular) {
        this.titular = titular;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public double getSaldo() {
        return saldo;
    }

    public void setSaldo(double saldo) {
        this.saldo = saldo;
    }
}
