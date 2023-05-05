namespace ConsoleApp1;

public sealed class BusinessClient: Client
{
    public override int Number { get; set; }
    public override decimal Balance { get; set; }
    public override string Address { get; set; }
    public DateTime CreationDate { get; set; }
    public override void GetSummary()
    {
        Console.WriteLine(Number);
        Console.WriteLine(Balance);
        Console.WriteLine(Address);
        Console.WriteLine(CreationDate);
    }
    
    public BusinessClient(string address, DateTime creationDate)
    {
        Address = address;
        CreationDate = creationDate;
    }
}