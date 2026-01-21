var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Serve default files like index.html
app.UseDefaultFiles();   // looks for index.html automatically
app.UseStaticFiles();    // serves files from wwwroot

//app.MapGet("/", () => "Hello World!");

app.Run();
