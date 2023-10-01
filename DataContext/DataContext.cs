using Aplicacao_de_vendas.Models;
using Microsoft.EntityFrameworkCore;

namespace Aplicacao_de_vendas.DataContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<Carinho> Carinho { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public  DbSet<Movimentos> Movimentos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
