<?php


class Conta
{
    // Atributos
    private string $titular;
    private float $saldo;
    private static int $numeroDeContas;


    // Construtor
    public function __construct(string $titular, float $saldo)
    {
        $this->titular = $titular;
        $this->saldo = $saldo;

        self::$numeroDeContas++;
    }


    // Métodos Públicos
    public function extrato(): string
    {
        return "$this->titular, seu saldo é de R$$this->saldo." . PHP_EOL;
    }

    public function depositar(float $valor): string
    {
        $this->saldo += $valor;
        return "Deposito realizado com sucesso no valor de R$$valor." . PHP_EOL;
    }

    public function sacar(float $valor): string
    {
        if ($this->saldo >= $valor) {
            $this->saldo -= $valor;
            return "Saque realizado com sucesso. Valor: R$$valor." . PHP_EOL;
        }
        return "Não foi possível realizar o saque no valor de R$$valor." . PHP_EOL;
    }

    public function transferir(float $valor, Conta $destino): string
    {
        if ($this->saldo >= $valor) {
            $this->sacar($valor);
            $destino->depositar($valor);
            return "Transferência realizada com sucesso no valor de R$$valor." . PHP_EOL;
        }

        return "Não foi possível realizar a transferência no valor de R$$valor." . PHP_EOL;
    }


    // Getters e Setters
    public static function getNumeroDeContas(): int
    {
        return self::$numeroDeContas;
    }
}