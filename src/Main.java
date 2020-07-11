public class Main {
    public static void main(String[] args) {

        Cliente lohana = new Cliente("Lohana Chaves", 2000, 222.222);
        Gerente marcio = new Gerente("Marcio Motta", 1999, 222.222);
        Programador lucas = new Programador("Lucas Santos", 1998, 222.212);

        lohana.depositar(500);
        lohana.depositar(5020);

        lohana.transferir(500, marcio);

        System.out.println(marcio.getSaldo());
    }
}
