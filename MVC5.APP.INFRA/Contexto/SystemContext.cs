using MVC5.APP.DOMAIN.Clientes.Entities;
using MVC5.APP.DOMAIN.Produtos.Entities;
using System.Data.Entity;

namespace MVC5.APP.INFRA.Produtos.Context
{
    public class SystemContext : DbContext
    {

        public SystemContext() : base("ecommerce")
        {
             
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                        .ToTable("Customers")
                        .HasKey(c => c.ClienteId)
                        .Property(c => c.Cpf)
                        .IsRequired();

            modelBuilder.Entity<Produto>()
                        .ToTable("Warehouse")
                        .HasKey(c => c.Id)
                        .Property(c => c.SKU)
                        .IsRequired();

            modelBuilder.Entity<Produto>()
                        .Property(c => c.Descricao)
                        .IsRequired();
            

            base.OnModelCreating(modelBuilder);
        }

    }
}
