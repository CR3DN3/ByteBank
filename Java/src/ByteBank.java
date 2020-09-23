import br.com.tavernadoshackers.funcionarios.Engenheiro;
import br.com.tavernadoshackers.funcionarios.Gerente;

public class ByteBank {
    public static void main(String[] args) {

        // Instância de Objetos
        Gerente joao = new Gerente("João Marcos", 123123123.70, 0, 21345.6);
        Engenheiro marcos = new Engenheiro("Marcos Santos", 123532343.70, 0, 32345.6);


        // Escopo
        System.out.println();

        joao.recebeSalario();
        marcos.recebeSalario();

        System.out.println();

        joao.transfere(2000, marcos);
        marcos.extrato();
    }
}
