using BackendAPI.Domain.Interfaces.Gateway;
using BackendAPI.Domain.Interfaces.UseCase;
using BackendAPI.Domain.UseCase;
using BackendAPI.Infrastructure.Gateway;
using Microsoft.AspNetCore.Diagnostics;
using DIExample.Infrastructure.Controllers.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder => builder.WithOrigins("http://localhost:4200") // URL de tu aplicación Angular
                          .AllowAnyHeader()
                          .AllowAnyMethod());
});


builder.Services.AddScoped<IEpisodeGateway, EpisodeGateway>();
builder.Services.AddScoped<IEpisodeUseCase, EpisodeUseCase>();
builder.Services.AddScoped<ICharacterGateway, CharacterGateway>();
builder.Services.AddScoped<ICharacterUseCase, CharacterUseCase>();

builder.Services.AddScoped<HttpClient>();
builder.Services.AddExceptionHandler<DIExample.Infrastructure.Controllers.Middlewares.ExceptionHandlerMiddleware>();
builder.Services.AddProblemDetails();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseExceptionHandler(o => o.UseExceptionHandler());

app.UseCors("AllowSpecificOrigin");

app.UseAuthorization();

app.MapControllers();

app.UsePathBase(new PathString("/api"));

app.Run();
