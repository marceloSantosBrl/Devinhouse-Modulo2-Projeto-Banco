// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
using ConsoleApp1.Services;

var clientService = new ClientService();
var flag = true;
do
{
    Console.WriteLine("Digite a operação que deseja realizar: \n" +
                      "1 - Abrir Conta\n" +
                      "2 - Consultar Conta\n" +
                      "3 - Listar todas as contas\n" +
                      "4 - Sair");
    var option = Console.ReadLine() ?? 
                 throw new ArgumentException("Valor inválido");
    switch (option)
    {
        case "1":
            clientService.AddClient();
            break;
        case "2":
            clientService.FindClient();
            break;
        case "3":
            clientService.ShowClients();
            break;
        case "4":
            flag = false;
            break;
        default:
            throw new ArgumentOutOfRangeException(nameof(option),
                $"O valor {option} não corresponde a nenhuma das alternativas");
    }
}while(flag);