namespace CatFactsWebApp.Services;


public interface ICatFactService
{
    Task<string> GetCatFactAsync();
}
