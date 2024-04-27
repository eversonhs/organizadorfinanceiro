using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<FinantialOrganizerDb>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("OrganizerFinantialDB")));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
