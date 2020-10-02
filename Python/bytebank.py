from sistema.conta import ContaCorrente

carlos = ContaCorrente("Carlos Alberto de Nóbrega", 12321123221, 20000)
marcelo = ContaCorrente("Marcelo Souza Pinto", 2321423424, 10)

carlos.transferir(200, marcelo)
print("\n")
marcelo.extrato()
