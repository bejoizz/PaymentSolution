using Microsoft.Extensions.DependencyInjection; 

namespace PaymentSolution.Utility
{
    public static class ServiceCollectionHelper
    {
        public static void Register<T,T1>(this IServiceCollection services)
        { 
            services.AddScoped(typeof(T), typeof(T1)); 
        }
    }
}
