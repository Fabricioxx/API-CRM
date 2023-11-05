using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_CRM.Models;

namespace API_CRM.Repository
{
    // Interface IClienteRepository
public interface IClienteRepository
{
    Task<IEnumerable<Cliente>> GetClientesAsync();
    Task<Cliente> GetClienteAsync(int clienteId);
    Task AddClienteAsync(Cliente cliente);
    Task<Cliente> UpdateClienteAsync(Cliente cliente);
    Task DeleteClienteAsync(int clienteId);
}
}