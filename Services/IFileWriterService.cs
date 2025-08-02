namespace CatFactsWebApp.Services;


public interface IFileWriterService
{
    Task AppendFactAsync(string fact);
    Task<string[]> ReadAllFactsAsync();

}
