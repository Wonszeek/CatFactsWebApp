using CatFactsWebApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddHttpClient<ICatFactService, CatFactService>();
builder.Services.AddScoped<IFileWriterService, FileWriterService>();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();

app.Run();
