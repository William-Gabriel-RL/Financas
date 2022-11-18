using EntityLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace RepoLayer.Context
{
    public class FinancasContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<CartaoDeCredito> CartoesDeCredito { get; set; }
        public DbSet<Despesa> Despesas { get; set; }
        public DbSet<Receita> Receitas { get; set; }

    }
}
