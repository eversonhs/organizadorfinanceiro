using Microsoft.EntityFrameworkCore;

class FinantialOrganizerDb: DbContext
{
    public FinantialOrganizerDb(DbContextOptions<FinantialOrganizerDb> options)
        : base(options) { }

    public DbSet<Account> Accounts { get; set; }
    public DbSet<CreditCard> CreditCards { get; set; }
    public DbSet<CreditCardBill> CreditCardBills { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<TransactionCategory> TransactionCategories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Account>()
            .Property(a => a.Type)
            .HasConversion<string>();
        modelBuilder
            .Entity<CreditCard>()
            .Property(c => c.Brand)
            .HasConversion<string>();
        modelBuilder
            .Entity<CreditCardBill>()
            .Property(c => c.Status)
            .HasConversion<string>();
        modelBuilder
            .Entity<Transaction>()
            .Property(c => c.Type)
            .HasConversion<string>();

    }
}