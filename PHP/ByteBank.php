<?php

require_once 'Sistema/Conta.php';

// Instância de Objetos
$junior = new Conta("Junior Matias Santos", 200);
$macela = new Conta("Macela Pernambucana", 1000);

// Escopo
echo $junior->depositar(200);
echo $macela->transferir(500, $junior);

// Saldo
echo PHP_EOL;
echo $junior->extrato();
echo $macela->extrato();