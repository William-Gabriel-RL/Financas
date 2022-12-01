using EntityLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace RepoLayer.Context
{
    public class FinancasContext : DbContext
    {
        public FinancasContext() { }
        public FinancasContext(DbContextOptions<FinancasContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Income> Incomes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("ConnectionString"));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).HasMaxLength(70).IsUnicode(false).IsRequired();
                entity.Property(e => e.Email).HasMaxLength(70).IsUnicode(false).IsRequired();
                entity.Property(e => e.Password).HasMaxLength(255).IsUnicode(false).IsRequired();
            });

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).HasMaxLength(30).IsUnicode(false).IsRequired();
                entity.Property(e => e.Bank).HasMaxLength(30).IsUnicode(false);
                entity.Property(e => e.Type).HasMaxLength(20).IsUnicode(false).IsRequired();
                entity.Property(e => e.Balance).HasColumnType("money").IsRequired();
                entity.Property(e => e.IdUser).HasColumnType("int").IsRequired();
            });

            modelBuilder.Entity<CreditCard>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Flag).HasMaxLength(30).IsUnicode(false).IsRequired();
                entity.Property(e => e.Issuer).HasMaxLength(30).IsUnicode(false);
                entity.Property(e => e.DueDate).HasColumnType("datetime").IsRequired();
                entity.Property(e => e.Closure).HasColumnType("datetime").IsRequired();
                entity.Property(e => e.Total).HasColumnType("money");
                entity.Property(e => e.Limit).HasColumnType("money").IsRequired();
                entity.Property(e => e.IdAccount).HasColumnType("int").IsRequired();
            });

            modelBuilder.Entity<Expense>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Description).HasMaxLength(150).IsUnicode(false);
                entity.Property(e => e.Amount).HasColumnType("money").IsRequired();
                entity.Property(e => e.PayDay).HasColumnType("datetime");
                entity.Property(e => e.Category).HasMaxLength(20).IsUnicode(false).IsRequired();
                entity.Property(e => e.Photo).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.IdAccount).HasColumnType("int").IsRequired();
                entity.Property(e => e.Paid).HasColumnType("bit");
                entity.Property(e => e.DueDate).HasColumnType("datetime").IsRequired();
                entity.Property(e => e.IdCreditCard).HasColumnType("int");
            });

            modelBuilder.Entity<Income>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Description).HasMaxLength(150).IsUnicode(false);
                entity.Property(e => e.Amount).HasColumnType("money").IsRequired();
                entity.Property(e => e.PayDay).HasColumnType("datetime");
                entity.Property(e => e.Category).HasMaxLength(20).IsUnicode(false).IsRequired();
                entity.Property(e => e.Photo).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.IdAccount).HasColumnType("int").IsRequired();
                entity.Property(e => e.Received).HasColumnType("bit");
            });
        }
    }
}
