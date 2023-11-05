using API_CRM.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_CRM.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DbContext _dbContext;

        public ClienteRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Cliente>> GetClientesAsync()
        {
            return await _dbContext.Set<Cliente>().ToListAsync();
        }

        public async Task<Cliente> GetClienteAsync(int clienteId)
        {
            return await _dbContext.Set<Cliente>().FirstOrDefaultAsync(c => c.Id == clienteId);
        }

        public async Task AddClienteAsync(Cliente cliente)
        {
            _dbContext.Set<Cliente>().Add(cliente);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Cliente> UpdateClienteAsync(Cliente cliente)
        {
            _dbContext.Set<Cliente>().Update(cliente);
            await _dbContext.SaveChangesAsync();
            return cliente;
        }

        public async Task DeleteClienteAsync(int clienteId)
        {
            var cliente = await _dbContext.Set<Cliente>().FirstOrDefaultAsync(c => c.Id == clienteId);

            if (cliente != null)
            {
                _dbContext.Set<Cliente>().Remove(cliente);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
