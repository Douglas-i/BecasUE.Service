using DataAccess;
using Domain;
using Domain.DTOs;
using Domain.Utilidades;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//---------------------------- Add services to the container.------------------------------

builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection")));

builder.Services.AddTransient<UniversidadDTO>();
builder.Services.AddTransient<UniversidadCreacionDTO>();
builder.Services.AddTransient<UniversidadEndPoints>();


builder.Services.AddTransient<SolicitudesAceptadasDTO>();
builder.Services.AddTransient<SolicitudesAceptadasCDTO>();
builder.Services.AddTransient<SolicitudesAceptadasEP>();

builder.Services.AddTransient<ExperienciaLaboralDTO>();
builder.Services.AddTransient<ExperienciaLaboralCDTO>();
builder.Services.AddTransient<ExperienciaLaboralEP>();

builder.Services.AddTransient<EstudiosAcademicosDTO>();
builder.Services.AddTransient<EstudiosAcademicosCDTO>();
builder.Services.AddTransient<EstudiosAcademicosEP>();

//Configuraciones para permitir peticiones desde el front
builder.Services.AddCors(options =>
{
    // Acceder a la configuración
    string allowedOrigins = builder.Configuration["FrontEnd_Url"];

    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins(allowedOrigins).AllowAnyMethod().AllowAnyHeader();
    });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ---------------------------------- app -----------------------------------------------

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
