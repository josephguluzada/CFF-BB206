// Add Services
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();


// Middleware
var app = builder.Build();

//app.MapGet("/bb206", () => "Hello BB206!");

app.MapControllerRoute
    (
        name: "default",
        pattern : "{Controller=bb206}/{Action=index}"
    );

app.Run();
