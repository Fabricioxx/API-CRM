using Microsoft.AspNetCore.Mvc;
using API_CRM.Models;
using API_CRM.Repository;

namespace API_CRM.Controllers
{
    [ApiController]
    [Route("api/clientes")]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;

        public ClientesController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        // GET: api/clientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            var clientes = await _clienteRepository.GetClientesAsync();
            return Ok(clientes);
        }

        // GET: api/clientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetCliente(int id)
        {
            var cliente = await _clienteRepository.GetClienteAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(cliente);
        }

        // POST: api/clientes
        [HttpPost]
        public async Task<ActionResult<Cliente>> PostCliente(Cliente cliente)
        {
            await _clienteRepository.AddClienteAsync(cliente);
            return CreatedAtAction("GetCliente", new { id = cliente.Id }, cliente);
        }

        // PUT: api/clientes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCliente(int id, Cliente cliente)
        {
            if (id != cliente.Id)
            {
                return BadRequest();
            }

            var updatedCliente = await _clienteRepository.UpdateClienteAsync(cliente);

            if (updatedCliente == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        // DELETE: api/clientes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            var cliente = await _clienteRepository.GetClienteAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }

            await _clienteRepository.DeleteClienteAsync(id);
            return NoContent();
        }
    }
}
