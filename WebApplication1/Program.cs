using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApplication1;
using WebApplication1.Config;
using WebApplication1.Interface;
using WebApplication1.Repositories;
using WebApplication1.Services;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IMajaRepository, MajaDbRepository>();
builder.Services.AddScoped<IDzivoklisRepository, DzivoklisDbRepository>();
builder.Services.AddScoped<IIedzivotajsRepository, IedzivotajsDbRepository>();


builder.Services.AddScoped<IMajaService, MajaService>();
builder.Services.AddScoped<IDzivoklisService, DzivoklisService>();
builder.Services.AddScoped<IIedzivotajsService, IedzivotajiService>();

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);


builder.Services.AddCors(options =>
{
    options.AddPolicy("MyCorsPolicy", builder =>
        builder.WithOrigins("http://localhost:4200")
               .AllowAnyHeader()
               .AllowAnyMethod());
});
var app = builder.Build();
app.UseCors("MyCorsPolicy");


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
