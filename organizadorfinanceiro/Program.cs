using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<FinantialOrganizerDb>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("OrganizerFinantialDB")));
builder.Services.AddControllers();
var app = builder.Build();
app.MapControllers();
app.Run();
