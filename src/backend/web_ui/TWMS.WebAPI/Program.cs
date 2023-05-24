using Microsoft.EntityFrameworkCore;
using NLog;
using TWMS.Application.CommonContracts;
using TWMS.Infrastructure.Persistence.DBContext;
using TWMS.WebAPI.Extensions;
using TWMS.WebAPI.ServiceExtension;

var builder = WebApplication.CreateBuilder(args);

LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(),
"/nlog.config"));

// Add services to the container.
builder.Services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureServiceManager();
builder.Services.ConfigureLoggerService();
//builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.ConfigureServices();
builder.Services.AddControllers(config => { config.RespectBrowserAcceptHeader = true; })
    .AddXmlDataContractSerializerFormatters()
    .AddApplicationPart(typeof(TWMS.Presentation.AssemblyReference).Assembly);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
var logger=app.Services.GetRequiredService<ILoggerManager>();
app.ConfigureExceptionHandler(logger);
if (app.Environment.IsDevelopment())
    app.UseHsts();

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
