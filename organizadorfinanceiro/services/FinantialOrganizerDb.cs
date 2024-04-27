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
        var accountEntity = modelBuilder.Entity<Account>();
        var creditCardEntity = modelBuilder.Entity<CreditCard>();
        var creditCardBillEntity = modelBuilder.Entity<CreditCardBill>();
        var TransactionEntity = modelBuilder.Entity<Transaction>();

        accountEntity.Property(a => a.Type).HasConversion<string>();
        accountEntity.Property(a => a.CreatedOn).HasDefaultValueSql("NOW()");
        accountEntity.Property(a => a.UpdatedOn).HasDefaultValueSql("NOW()");

        creditCardEntity.Property(c => c.Brand).HasConversion<string>();
        creditCardEntity.Property(c => c.CreatedOn).HasDefaultValueSql("NOW()");
        creditCardEntity.Property(c => c.UpdatedOn).HasDefaultValueSql("NOW()");

        creditCardBillEntity.Property(c => c.Status).HasConversion<string>();
        creditCardBillEntity.Property(c => c.CreatedOn).HasDefaultValueSql("NOW()");
        creditCardBillEntity.Property(c => c.UpdatedOn).HasDefaultValueSql("NOW()");

        TransactionEntity.Property(t => t.Type).HasConversion<string>();
        TransactionEntity.Property(t => t.CreatedOn).HasDefaultValueSql("NOW()");
        TransactionEntity.Property(t => t.UpdatedOn).HasDefaultValueSql("NOW()");
    }
}