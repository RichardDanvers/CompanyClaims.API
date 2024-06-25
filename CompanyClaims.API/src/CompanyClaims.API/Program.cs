using CompanyClaims.API.Configuration;
using CompanyClaims.Data.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Register();
builder.Services.AddAutoMapper(typeof(DefaultAutoMapperProfile));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<CompanyClaimsDbContext>();
    SeedDatabase.Seed(context);
}

app.Run();
