using Microsoft.EntityFrameworkCore;
using TWMS.Application.Contracts;
using TWMS.Infrastructure.Persistence.DBContext;
using TWMS.Infrastructure.Services;

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
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<CustomerAddressService, CustomerAddressService>();
            services.AddScoped<IStaffService, StaffService>();
            services.AddScoped<IOrderService,OrderService>();
            //services.AddScoped<IProductService, ProductService>();
        }
    }
}
