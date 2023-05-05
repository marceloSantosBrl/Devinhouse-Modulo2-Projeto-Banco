namespace ConsoleApp1;

public sealed class IndividualClient: Client
{
    public override int Number { get; set; }
    public override decimal Balance { get; set; }
    public override string Address { get; set; }
    public string Cpf { get; set; }
    public DateTime BirthDay { get; set; }
    public override void GetSummary()
    {
        Console.WriteLine(Number);
        Console.WriteLine(Balance);
        Console.WriteLine(Address);
        Console.WriteLine(BirthDay);
    }

    public IndividualClient(string address, DateTime birthDay, string cpf)
    {
        Address = address;
        BirthDay = birthDay;
        Cpf = cpf;
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