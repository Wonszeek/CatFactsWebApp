namespace CatFactsWebApp.Services;

public class FileWriterService : IFileWriterService
{
    private const string FilePath = "catfacts.txt";

    public async Task AppendFactAsync(string fact)
    {
        await File.AppendAllTextAsync(FilePath, fact + Environment.NewLine);
    }
}
