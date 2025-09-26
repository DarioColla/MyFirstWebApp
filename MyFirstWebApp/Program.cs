var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.UseDefaultFiles(); // ik ga opzoek naar index.HTML of default.HTML
app.UseStaticFiles(); // default folder voor HTML bestanden vind je terug in root folder
app.MapRazorPages(); // Folder pages
app.Run();
