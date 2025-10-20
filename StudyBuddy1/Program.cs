using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add Razor components for Blazor
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Enable static files (for CSS, JS, etc.)
app.UseStaticFiles();

// Enable routing
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Run the app
app.Run();
