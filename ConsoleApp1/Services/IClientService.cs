namespace ConsoleApp1.Services;

public interface IClientService
{
    public Client FindClient();
    public void ShowClients();
    public void AddClient();
}