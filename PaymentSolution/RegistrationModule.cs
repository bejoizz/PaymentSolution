using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PaymentData;
using PaymentSolution.Logic;
using PaymentSolution.Services;
using PaymentSolution.Utility; 
namespace PaymentSolution
{
    public static class RegistrationModule
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        { 
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            RegisterMappper(services);
            RegisterDependencies(services);
        }
        private static void RegisterDependencies(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>)); 
            services.Register<IDataTransactions,DataTransactions>();
            services.Register<IServiceLogic, ServiceLogic>();
            services.Register<IPaymentLogic, PaymentLogic>();
            services.Register<ICheapPaymentGateway, CheapPaymentGateway>();
            services.Register<IExpensivePaymentGateway, ExpensivePaymentGateway>();
            services.Register<IPremiumPaymentService, PremiumPaymentService>();  


        }
        private static void RegisterMappper(IServiceCollection services)
        {

            var config = new MapperConfiguration(c =>
            {
                c.AddProfile(new ApplicationProfile());
            });
            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
