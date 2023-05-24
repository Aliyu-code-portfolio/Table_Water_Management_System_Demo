using Microsoft.EntityFrameworkCore;
using TWMS.Application.CommonContracts;
using TWMS.Application.Contracts;
using TWMS.Infrastructure.Persistence.DBContext;
using TWMS.Infrastructure.Persistence.Repositories;
using TWMS.Infrastructure.ServiceContracts;
using TWMS.Infrastructure.Services;
using TWMS.LoggerService.LogService;

namespace TWMS.WebAPI.ServiceExtension
{
    public static class ServiceExtensions
    {
        public static void ConfigureDbContext(this IServiceCollection services)
        {
            //services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));

        }
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Program));
            /*services.AddScoped<ICustomerRepository, CustomerService>();
            services.AddScoped<CustomerAddressService, CustomerAddressService>();
            services.AddScoped<IStaffRepository, StaffService>();
            services.AddScoped<IOrderRepository,OrderService>();*/
            //services.AddScoped<IProductService, ProductService>();
        }
        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }
        public static void ConfigureServiceManager(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
        }
        public static void ConfigureLoggerService(this IServiceCollection services) 
        {
            services.AddSingleton<ILoggerManager,LoggerManager>();
        }
        public static void ConfigureSqlContext(this IServiceCollection services,
            IConfiguration configuration) =>
            services.AddDbContext<RepositoryContext>(opts =>
            opts.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString"))); 
    }
}
