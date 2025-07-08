using Microsoft.EntityFrameworkCore;

namespace Finances.Models
{
    public class FinanceDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public FinanceDbContext(DbContextOptions<FinanceDbContext> options) : base(options)
        {
                
        }
    }
}
