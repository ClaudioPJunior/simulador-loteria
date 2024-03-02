using Loteria.Simulador.Infrastructure.Ioc;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddSwaggerGen(sw =>
{
    sw.SwaggerDoc("v1", new OpenApiInfo { Title = "Simulador Loteria - API", Version = "v1" });
    sw.EnableAnnotations();
});


BootStrapper.ConfigureContainer(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(swUi =>
    {
        swUi.SwaggerEndpoint("/swagger/v1/swagger.json", "Simulador Loteria - API");
    });
}

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
