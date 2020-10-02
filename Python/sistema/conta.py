class ContaCorrente:

    # Construtor
    def __init__(self, titular, cpf, saldo):
        """
        Atributos do construtorr
        """
        self._titular = titular.title()
        self._cpf = cpf
        self._saldo = saldo

    # Métodos
    @staticmethod
    def codigo_banco():
        print(f"O código do banco é: 001")

    def extrato(self):
        """
        Retorna o extrato com as informações
        do titular e do saldo.
        """
        print(f"{self._titular}, seu saldo é de R${self._saldo}")

    def depositar(self, valor):
        """
        Deposita uma certa quantia
        na conta corrente atual.
        """
        self._saldo += valor
        print(f"Deposito no valor de R${valor}, feito com sucesso!")

    def sacar(self, valor):
        """
        Saca uma certa quantia
        na conta corrente atual.
        """
        self._saldo -= valor
        print(f"Saque no valor de R${valor}, feito com sucesso!")

    def transferir(self, valor, destino):
        """
        Transfere uma certa quantia
        da conta origem para conta destino.

        Verifica o saldo da conta origem
        caso for falso ele não transferirá.
        """
        if self._saldo >= valor:
            self.sacar(valor)
            destino.depositar(valor)
            print(f"Transferência no valor de R${valor}, feita com sucesso para {destino.titular}")
        else:
            print("Saldo insuficiênte, tente novamente mais tarde.")

    # Getters e Setters
    @property
    def titular(self):
        return self._titular

    @property
    def cpf(self):
        return self._cpf

    @property
    def saldo(self):
        return self._saldo

    # Setters
    @titular.setter
    def titular(self, titular):
        self._titular = titular

    @cpf.setter
    def cpf(self, cpf):
        self._cpf = cpf

    @saldo.setter
    def saldo(self, saldo):
        self._saldo = saldo
