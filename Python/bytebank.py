from sistema.conta import ContaCorrente

# Objetos
carlos = ContaCorrente("Carlos Alberto de Nóbrega", 12321123221, 20000)
marcelo = ContaCorrente("Marcelo Souza Pinto", 2321423424, 10)

# Escopo
ContaCorrente.codigo_banco()
print()
carlos.transferir(200, marcelo)
marcelo.extrato()
