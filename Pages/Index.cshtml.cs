using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CatFactsWebApp.Services;

public class IndexModel : PageModel
{
    private readonly ICatFactService _catFactService;
    private readonly IFileWriterService _fileWriter;

    public IndexModel(ICatFactService catFactService, IFileWriterService fileWriter)
    {
        _catFactService = catFactService;
        _fileWriter = fileWriter;
    }

    [BindProperty]
    public string? CatFact { get; set; }

    public void OnGet() { }

    public async Task<IActionResult> OnPostAsync()
    {
        CatFact = await _catFactService.GetCatFactAsync();
        await _fileWriter.AppendFactAsync(CatFact);
        return Page();
    }
}
