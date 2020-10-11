package br.com.tavernadoshackers.sistema;

public class ContaCorrente extends Conta {

    // Construtor
    public ContaCorrente(String nome, double cpf, double saldo, double numeroConta) {
        super(nome, cpf, saldo, numeroConta);
    }


    // Métodos
    public void liberarRendimento() {
        this.setSaldo(this.getSaldo() * 0.05);
    }

}
