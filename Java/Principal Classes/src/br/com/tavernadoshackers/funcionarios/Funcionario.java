package br.com.tavernadoshackers.funcionarios;

import br.com.tavernadoshackers.sistema.Conta;

public abstract class Funcionario extends Conta {

    // Atributos
    private double salario;

    // Construtor
    public Funcionario(String nome, double cpf, double saldo, double numeroConta) {
        super(nome, cpf, saldo, numeroConta);
    }

    // Métodos
    public void pedirDemissao() {
        boolean demissao = true;
        System.out.println(this.getNome() + ", foi demitido.");
    }

    // Métodos Abstratos
    public abstract void recebeSalario();

    public abstract void recebeBonificacao();

    // Getters e Setters
    public double getSalario() {
        return salario;
    }
}
