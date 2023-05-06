namespace ConsoleApp1.Services;

public class ClientService
{
    public static List<Client> Clients { get; set; } = new();

    public static void AddClient()
    {
        Console.WriteLine("Qual tipo de conta deseja criar?\n" +
                          "1 - Conta PF\n" +
                          "2 - Conta PJ\n" +
                          "Entre outro valor para sair");
        var accountType = Console.ReadLine();
        if (accountType == "1")
        {
            var client = CreateIndividualClient();
            Clients.Add(client);
        }
        else
        {
            var client = CreateBusinessClient();
            Clients.Add(client);
        }
    }

    public static BusinessClient CreateBusinessClient()
    {
        Console.WriteLine("Digite o número da conta");
        int.TryParse(Console.ReadLine(), out var number);
        Console.WriteLine("Digite o nome do negócio");
        Console.WriteLine("Digite o Endereço");
        var businessName = Console.ReadLine() ??
                           throw new ArgumentException("Argumento inválido");
        var address = Console.ReadLine() ??
                      throw new ArgumentException("Argumento inválido");
        Console.WriteLine("Digite CNPJ do Negócio");
        var cnpj = Console.ReadLine() ??
                   throw new ArgumentException("Argumento inválido");
        Console.WriteLine("Digite o ano de inauguração do Negócio");
        int.TryParse(Console.ReadLine(), out var year);
        if (year > DateTime.Now.Year)
        {
            throw new ArgumentOutOfRangeException(nameof(year), $"Ano {year} maior" +
                                                                $"que o ano atual");
        }

        Console.WriteLine("Digite o mês de inauguração do Negócio");
        int.TryParse(Console.ReadLine(), out var month);
        if (month > 12)
        {
            throw new ArgumentOutOfRangeException(nameof(month), $"Mês {month}" +
                                                                 $"maior que 12");
        }

        Console.WriteLine("Digite o dia de inauguração do Negócio");
        int.TryParse(Console.ReadLine(), out var day);
        if (day > 31)
        {
            throw new ArgumentOutOfRangeException(nameof(day), $"Dia {day} maior " +
                                                               $"que 31");
        }

        var creationDateTime = new DateTime(year, month, day);
        return new BusinessClient(number: number, businessName: businessName,
            address: address, creationDate: creationDateTime, cnpj: cnpj);
    }

    public static IndividualClient CreateIndividualClient()
    {
        Console.WriteLine("Digite o nome do cliente");
        var name = Console.ReadLine() ??
                   throw new ArgumentException("Argumento inválido");
        Console.WriteLine("Digite o número da conta");
        int.TryParse(Console.ReadLine(), out var number);
        Console.WriteLine("Digite o Endereço");
        var address = Console.ReadLine() ??
                      throw new ArgumentException("Argumento inválido");
        Console.WriteLine("Digite CNPJ do Negócio");
        var cpf = Console.ReadLine() ??
                  throw new ArgumentException("Argumento inválido");

        Console.WriteLine("Digite o ano de nascimento");
        int.TryParse(Console.ReadLine(), out var year);
        if (year > DateTime.Now.Year)
        {
            throw new ArgumentOutOfRangeException(nameof(year), $"Ano {year} maior" +
                                                                $"que o ano atual");
        }

        Console.WriteLine("Digite o mês de nascimento");
        int.TryParse(Console.ReadLine(), out var month);
        if (month > 12)
        {
            throw new ArgumentOutOfRangeException(nameof(month), $"Mês {month}" +
                                                                 $"maior que 12");
        }

        Console.WriteLine("Digite o dia do nascimento");
        int.TryParse(Console.ReadLine(), out var day);
        if (day > 31)
        {
            throw new ArgumentOutOfRangeException(nameof(day), $"Dia {day} maior " +
                                                               $"que 31");
        }

        var birthDateTime = new DateTime(year, month, day);
        if (!IndividualClient.IsLegalAge(birthDateTime))
        {
            throw new ArgumentOutOfRangeException(nameof(birthDateTime),
                $"Dado o ano de nascimento {birthDateTime}, o cliente é menor de idade");
        }

        return new IndividualClient(number: number, address: address,
            birthDay: birthDateTime, cpf: cpf, name: name);
    }
}