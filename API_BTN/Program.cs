using API_BTN.Data_Context;
using API_BTN.Repository.CategoryRepository;
using API_BTN.Repository.DetailRepository;
using API_BTN.Repository.InforRepository;
using API_BTN.Service.CategoryService;
using API_BTN.Service.DetailService;
using API_BTN.Service.InforService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Setting Cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

// connext Database
builder.Services.AddDbContext<ApplicationDbContext>(option =>
    option.UseSqlServer(
        builder.Configuration.GetConnectionString("ConnectData"))
);

// set use the services and repository
// repository 
builder.Services.AddScoped<ICategoryRepository, CategoryRepositoryImpl>();
builder.Services.AddScoped<IInforRepository, InforRepositoryImpl>();   
builder.Services.AddScoped<IDetailsRepository, DetailsRepositoryImpl>();    
// service
builder.Services.AddScoped<ICategoryService, CategoryServiceImpl>();
builder.Services.AddScoped<IInforService, InforServiceImpl>();
builder.Services.AddScoped<IDetailsService, DetailServiceimp>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAllOrigins");

app.UseAuthorization();

app.MapControllers();

app.Run();
