package Funcionarios;

import Sistema.Conta;

public abstract class Funcionario extends Conta {

    // Atributos
    private double salario;
    private boolean demissao;

    // Construtor
    public Funcionario(String nome, double cpf, double saldo, double numeroConta) {
        super(nome, cpf, saldo, numeroConta);
    }


    // Métodos
    public void pedirDemissao() {
        this.demissao = true;
        System.out.println(this.getNome() + ", foi demitido.");
    }

    // Métodos Abstratos
    public abstract void recebeSalario();
    public abstract void recebeBonificacao();


    // Getters e Setters
    public double getSalario() {
        return salario;
    }

    public void setSalario(double salario) {
        this.salario = salario;
    }

    public boolean isDemissao() {
        return demissao;
    }

    public void setDemissao(boolean demissao) {
        this.demissao = demissao;
    }
}
