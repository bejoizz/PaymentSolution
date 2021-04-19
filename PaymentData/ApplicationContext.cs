using Microsoft.EntityFrameworkCore; 
using PaymentData.Mappers;
using PaymentSolution.Models;

namespace PaymentData
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new PaymentStateMap(modelBuilder.Entity<PaymentState>());
            new CardMap(modelBuilder.Entity<Card>());
        }
    }
}
