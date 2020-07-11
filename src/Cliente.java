public class Cliente extends Conta {
    // Atributos
    private String nome;
    private int anoNascimento;
    private double cpf;
    private boolean statusConta;


    // Métodos
    // Construtor
    public Cliente(String nome, int anoNascimento, double cpf) {
        this.nome = nome;
        this.anoNascimento = anoNascimento;
        this.cpf = cpf;
        System.out.println(this.nome + " sua conta foi aberta com sucesso!");
    }

    // Método para fechar contas no ByteBank
    public void fecharConta() {
        if (this.statusConta) {
            this.setStatusConta(false);
            System.out.println("Conta fechada com sucesso!");
        } else {
            System.out.println("A sua conta já está fechada.");
        }
    }


    // Getters e Setters
    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public int getAnoNascimento() {
        return anoNascimento;
    }

    public void setAnoNascimento(int anoNascimento) {
        this.anoNascimento = anoNascimento;
    }

    public double getCpf() {
        return cpf;
    }

    public void setCpf(double cpf) {
        this.cpf = cpf;
    }

    public boolean isStatusConta() {
        return statusConta;
    }

    public void setStatusConta(boolean statusConta) {
        this.statusConta = statusConta;
    }
}