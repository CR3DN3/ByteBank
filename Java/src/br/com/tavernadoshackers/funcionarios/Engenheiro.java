package br.com.tavernadoshackers.funcionarios;

public class Engenheiro extends Funcionario {

    // Construtor
    public Engenheiro(String nome, double cpf, double saldo, double numeroConta) {
        super(nome, cpf, saldo, numeroConta);
    }

    // Métodos
    @Override
    public void recebeSalario() {
        this.deposita(20000);
    }

    @Override
    public void recebeBonificacao() {
        this.deposita(this.getSalario() * 0.15);
    }
}
