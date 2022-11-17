using EntityLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace RepoLayer.Context
{
    public class FinancasContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
