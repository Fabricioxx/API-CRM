
using API_CRM.Models;
using Microsoft.EntityFrameworkCore;

namespace API_CRM.Data
{
    public class Contexto : DbContext // DbContext - classe da biblioteca EntityFrameworkCore
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        // Define as entidades (tabelas) do banco de dados
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        // Configurações adicionais, como chaves primárias, índices, relacionamentos, etc.
    }
}
