class ContaCorrente:
    """
    Construtor
    """

    def __init__(self, titular, cpf, saldo):
        """
        Atributos do construtorr
        """
        self.__titular = titular
        self.__cpf = cpf
        self.__saldo = saldo

    def extrato(self):
        """
        Retorna o extrato com as informações
        do titular e do saldo.
        """
        print(f"{self.__titular}, seu saldo é de R${self.__saldo}")

    def depositar(self, valor):
        """
        Deposita uma certa quantia
        na conta corrente atual.
        """
        self.__saldo += valor
        print(f"Deposito no valor de R${valor}, feito com sucesso!")

    def sacar(self, valor):
        """
        Saca uma certa quantia
        na conta corrente atual.
        """
        self.__saldo -= valor
        print(f"Saque no valor de R${valor}, feito com sucesso!")

    def transferir(self, valor, destino):
        """
        Transfere uma certa quantia
        da conta origem para conta destino.

        Verifica o saldo da conta origem
        caso for falso ele não transferirá.
        """
        if self.__saldo >= valor:
            self.sacar(valor)
            destino.depositar(valor)
            print(f"Transferência no valor de R${valor}, feita com sucesso para {destino.__titular}")
        else:
            print("Saldo insuficiênte, tente novamente mais tarde.")
