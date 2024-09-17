using ATM.Models;
using Microsoft.EntityFrameworkCore;

namespace ATM.Data;

public class ATMContext : DbContext
{
    public DbSet<Account> Accounts { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<History> Histories { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
    }
}