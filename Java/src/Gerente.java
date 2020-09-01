public class Gerente extends Funcionario {

    // Métodos
    // Construtor
    public Gerente(String nome, int anoNascimento, double cpf) {
        super(nome, anoNascimento, cpf);
        this.setSalario(3000);
    }
}
