﻿using DesafioEstacionamento.Models;



Estacionamento es = new Estacionamento(2);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{

    Console.WriteLine("--Bem vindo ao MF Estacionamentos!---");
    Console.WriteLine("Digite a ação:");
    Console.WriteLine("1 - Cadastrar Veiculo");
    Console.WriteLine("2 - Remover Veiculo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.CadastrarVeiculo();
            break;
        case "2":
            es.RemoverVeiculo();
            break;
        case "3":
            es.ListarVeiculos();
            break;
        case "4":
            Console.WriteLine("Encerrado!");
            Environment.Exit(0);
            break;

    }
}

//Console.WriteLine("Quantas horas pretende ficar(Minimo 1 hora):");




