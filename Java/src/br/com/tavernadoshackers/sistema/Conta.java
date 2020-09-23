package br.com.tavernadoshackers.sistema;

public class Conta {

    // Atributos
    private String nome;
    private double cpf;
    private double saldo;
    private static int idConta;
    private double numeroConta;
    private double agenciaConta;

    // Construtor
    public Conta(String nome, double cpf, double saldo, double numeroConta) {
        this.nome = nome;
        System.out.println(nome + ", sua conta foi criada com sucesso!");
    }


    // Métodos
    public void extrato() {
        System.out.println(this.nome + ", seu saldo é de R$" + this.saldo);
    }

    public void deposita(double valor) {
        this.saldo = valor;
        System.out.println("Deposito realizado com sucesso! Valor: R$" + valor);
    }

    public void saca(double valor) {
        this.saldo -= valor;
        System.out.println("Saque realizado com sucesso! Valor: R$" + valor);
    }

    public void transfere(double valor, Conta destino) {
        if (this.saldo >= valor) {
            this.saldo -= valor;
            destino.saldo += valor;
            System.out.println("Transferência realizada com sucesso! Valor: R$" + valor);
        } else {
            System.out.println("Transferência não pode ser realizada. (Saldo insuficiênte!)");
        }
    }


    // Getters e Setters
    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public double getCpf() {
        return cpf;
    }

    public void setCpf(double cpf) {
        this.cpf = cpf;
    }

    public double getSaldo() {
        return saldo;
    }

    public void setSaldo(double saldo) {
        this.saldo = saldo;
    }

    public static int getIdConta() {
        return idConta;
    }

    public static void setIdConta(int idConta) {
        Conta.idConta = idConta;
    }

    public double getNumeroConta() {
        return numeroConta;
    }

    public void setNumeroConta(double numeroConta) {
        this.numeroConta = numeroConta;
    }

    public double getAgenciaConta() {
        return agenciaConta;
    }

    public void setAgenciaConta(double agenciaConta) {
        this.agenciaConta = agenciaConta;
    }
}
