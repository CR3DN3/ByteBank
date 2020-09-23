package br.com.tavernadoshackers.funcionarios;

public class Gerente extends Funcionario {

    // Construtor
    public Gerente(String nome, double cpf, double saldo, double numeroConta) {
        super(nome, cpf, saldo, numeroConta);
    }


    // Métodos
    @Override
    public void recebeSalario() {
        this.deposita(15000);
    }

    @Override
    public void recebeBonificacao() {
        this.deposita(this.getSalario() * 0.15);
    }
}
