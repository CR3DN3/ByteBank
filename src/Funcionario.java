public abstract class Funcionario extends Cliente {

    // Atributos
    private double salario;

    public Funcionario(String nome, int anoNascimento, double cpf) {
        super(nome, anoNascimento, cpf);
    }

    // Meétodos abstratos
    public void verificarCliente(Cliente cliente) {
        System.out.println("Nome: " + cliente.getNome());
        System.out.println("Ano de Nascimento: " + cliente.getAnoNascimento());
        System.out.println("CPF: " + cliente.getCpf());
    }

    public void ganharBonus(double valor) {
        this.setSalario(this.getSalario() + valor);
        System.out.println("O gerente " + this.getNome() + ", ganhou um bônus de R$ " + valor + ".");
        System.out.println("Seu salário é de " + this.getSalario());
    }


    // Getters e Setters
    public double getSalario() {
        return salario;
    }

    public void setSalario(double salario) {
        this.salario = salario;
    }
}