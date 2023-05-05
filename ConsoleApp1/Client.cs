namespace ConsoleApp1;

public abstract class Client
{
    public abstract int Number { get; set; }
    public abstract decimal Balance { get; set; }
    public abstract string Address { get; set; }
    public abstract void GetSummary();
}