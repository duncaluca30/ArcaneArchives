using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BookStoreAPI.Data; // Ensure the namespace 'BookStoreAPI.Data' exists and is correctly defined in your project  

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("https://localhost:7026");

// Add services to the container.  
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
});

// Add Entity Framework Core for SQL Server  
builder.Services.AddDbContext<BookStoreContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("BookStoreDB")));

// Enable Swagger for API documentation  
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.  
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();