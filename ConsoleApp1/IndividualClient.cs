namespace ConsoleApp1;

public sealed class IndividualClient: Client
{
    public override int Number { get; set; }
    public override decimal Balance { get; set; }
    public override string Address { get; set; }
    public DateTime BirthDay { get; set; }
    public override void GetSummary()
    {
        Console.WriteLine(Number);
        Console.WriteLine(Balance);
        Console.WriteLine(Address);
        Console.WriteLine(BirthDay);
    }

    public IndividualClient(string address, DateTime birthDay)
    {
        Address = address;
        BirthDay = birthDay;
    }
}