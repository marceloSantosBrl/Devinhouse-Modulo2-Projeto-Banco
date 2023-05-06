namespace ConsoleApp1;

public sealed class BusinessClient: Client
{
    public override int Number { get; set; }
    public override decimal Balance { get; set; }
    public override string Address { get; set; }
    public string Cnpj { get; set; }
    public DateTime BusinessCreationDate { get; set; }
    public override void GetSummary()
    {
        Console.WriteLine(Number);
        Console.WriteLine(Balance);
        Console.WriteLine(Address);
        Console.WriteLine(BusinessCreationDate);
    }
    
    public BusinessClient(int number, string address, DateTime creationDate, string cnpj)
    {
        Number = number;
        Address = address;
        BusinessCreationDate = creationDate;
        Cnpj = cnpj;
    }
}