package br.com.tavernadoshackers.sistema;

public abstract class Conta {

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
        this.cpf = cpf;
        this.saldo = saldo;
        this.numeroConta = numeroConta;
        System.out.println(nome + ", sua conta foi criada com sucesso!");
    }

    // Métodos:
    public void verificarInformacoes() {
        System.out.println("");
    }

    public void extrato() {
        System.out.println(this.nome + ", seu saldo é de R$" + this.saldo);
    }

    // Deposita um valor que é passado por argumento.
    public void deposita(double valor) {
        this.saldo = valor;
        System.out.println("Deposito realizado com sucesso! Valor: R$" + valor);
    }

    // Saca um valor que é passado por argumento.
    public void saca(double valor) {
        this.saldo -= valor;
        System.out.println("Saque realizado com sucesso! Valor: R$" + valor);
    }

    // Transfere um valor passado por argumento
    // ao destino que também é passado por argumento.
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
        return this.nome;
    }

    public double getSaldo() {
        return this.saldo;
    }

    public void setSaldo(double saldo) {
        this.saldo = saldo;
    }
}
