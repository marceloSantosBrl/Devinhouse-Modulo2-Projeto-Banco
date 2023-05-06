namespace ConsoleApp1;

public sealed class IndividualClient : Client
{
    public override int Number { get; set; }
    public override decimal Balance { get; set; }
    public override string Address { get; set; }
    public string Name { get; set; }
    public string Cpf { get; set; }
    public DateTime BirthDay { get; set; }

    public override void GetSummary()
    {
        Console.WriteLine("#####");
        Console.WriteLine("Nome: " + Name);
        Console.WriteLine("Numero da conta: " + Number);
        Console.WriteLine("Balanço: " + Balance);
        Console.WriteLine("Endereço: " + Address);
        Console.WriteLine("Data de nascimento: " + BirthDay);
        Console.WriteLine("#####");
    }

    public IndividualClient(int number, string address, DateTime birthDay, string cpf, string name)
    {
        Number = number;
        Address = address;
        BirthDay = birthDay;
        Cpf = cpf;
        Name = name;
    }

    public static bool IsLegalAge(DateTime birthday)
    {
        if (birthday > DateTime.Now)
        {
            throw new ArgumentOutOfRangeException(nameof(birthday), $"Data de nascimento{birthday} é maior " +
                                                                    $"que a data de hoje");
        }

        return (birthday.AddYears(18) <= DateTime.Now);
    }
}