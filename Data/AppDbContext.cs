using DesafioApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Desafio.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Produto> Products { get; set; }
        public DbSet<Transacões> Transacao { get; set; }
        public DbSet<ProdutoLista> ProdutoLista { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("DataSource=app.db; Cache=Shared");
        }
    }
}
