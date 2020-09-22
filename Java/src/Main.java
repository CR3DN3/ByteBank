import Funcionarios.Desenvolvedor;
import Funcionarios.Gerente;
import Sistema.ContaCorrente;

public class Main {
    public static void main(String[] args) {

        // Instância de Objetos
        Gerente julio = new Gerente("Júlio Sabugo", 23242, 123);
        Desenvolvedor silva = new Desenvolvedor("Silva Alberto", 23542, 123);


        // Escopo
        System.out.println();

        silva.extrato();
        julio.extrato();

        System.out.println();

        System.out.println(silva.getSalarioAtual());
        System.out.println(julio.getSalarioAtual());
    }
}