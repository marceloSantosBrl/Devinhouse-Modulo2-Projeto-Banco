namespace ConsoleApp1;

public sealed class BusinessClient: Client
{
    public override int Number { get; set; }
    public string BusinessName { get; set; }
    public override decimal Balance { get; set; }
    public override string Address { get; set; }

    public string Cnpj { get; set; }

    public DateTime BusinessCreationDate { get; set; }

    public override void GetSummary()
    {
        Console.WriteLine("Cnpj: " + Cnpj);
        Console.WriteLine("Razão social: " + BusinessName);
        Console.WriteLine("Numero da conta: " +  Number);
        Console.WriteLine("Balanço:" + Balance);
        Console.WriteLine("Endereço " + Address);
        Console.WriteLine("Data de criação do negócio" + BusinessCreationDate);
    }

    public BusinessClient(int number, string address, DateTime creationDate, string cnpj, string businessName)
    {
        Number = number;
        Address = address;
        BusinessCreationDate = creationDate;
        Cnpj = cnpj;
        BusinessName = businessName;
    }
}