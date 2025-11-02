using ViewQuiz.Components;

// Program.cs (minimal .NET 8)
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
// register your services (QuizService etc.) here:
// builder.Services.AddSingleton<IQuizService, InMemoryQuizService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

