public class Programador extends Funcionario {

    // Métodos
    // Construtor
    public Programador(String nome, int anoNascimento, double cpf) {
        super(nome, anoNascimento, cpf);
        this.setSalario(5000);
    }

    public boolean programar() {
        System.out.println(this.getNome() + " está programando...");
        return true;
    }
}
