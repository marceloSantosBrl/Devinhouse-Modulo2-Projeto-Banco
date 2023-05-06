namespace ConsoleApp1.Services;

public interface IClientService
{
    public Client FindClient(int number);
    public void ShowClients();
    public void AddClient();
}