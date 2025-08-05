using AutoMapper;
using Business;
using Business.Interfaces;
using Business.Services;
using Data;
using Data.Implements.PlayerData;
using Data.Implements.UserData;
using Data.Interfaces;
using Entity.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Utilities.Interfaces;
using Utilities.Jwt;
using Utilitis.Mappers;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(cfg => { }, typeof(UserProfile));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registrar clases
builder.Services.AddScoped<ICardData, CardData>();
builder.Services.AddScoped<ICardBusiness, CardBusiness>();

builder.Services.AddScoped<IDeckData, DeckData>();
builder.Services.AddScoped<IDeckBusiness, DeckBusiness>();

builder.Services.AddScoped<IPlayerData, PlayerData>();
builder.Services.AddScoped<IPlayerBusiness, PlayerBusiness>();

builder.Services.AddScoped<IRoomData, RoomData>();
builder.Services.AddScoped<IRoomBusiness, RoomBusiness>();

builder.Services.AddScoped<IRoundData, RoundData>();
builder.Services.AddScoped<IRoundBusiness, RoundBusiness>();

builder.Services.AddScoped<IShiftData, ShiftData>();
builder.Services.AddScoped<IShiftBusiness, ShiftBusiness>();

builder.Services.AddScoped<IUserData, UserData>();
builder.Services.AddScoped<IUserBusiness, UserBusiness>();

builder.Services.AddScoped<IAuthBusiness, AuthBusiness>();
builder.Services.AddScoped<IJwtGenerator,  JwtGenerator>();
builder.Services.AddScoped<IJwtBusiness, JwtBusiness>();



//Agregar CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy
            .WithOrigins("http://127.0.0.1:5500") // o tu IP/puerto de frontend
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});




//Agregar DbContext
builder.Services.AddDbContext<ApplicationDbContext>(opciones =>
    opciones.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

app.UseHttpsRedirection();

app.UseCors("AllowFrontend");


app.UseAuthorization();



app.MapControllers();

    app.Run();



