using CarrinhoDeCompras.MVC.Models;
using System.Data.Entity;

namespace CarrinhoDeCompras.MVC.Contexts
{
    public class EfContext : DbContext
    {
        public EfContext() : base("Asp_Net_MVC_CS")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EfContext>);
        }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Fabricante> Fabricantes { get; set; }

        public DbSet<Produto> Produto { get; set; }
    }
}