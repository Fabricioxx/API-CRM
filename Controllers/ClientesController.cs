using Microsoft.AspNetCore.Mvc;
using API_CRM.Models;
using API_CRM.Repository;
using API_CRM.DTO;
using Microsoft.EntityFrameworkCore;

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
        public async Task<ActionResult<Cliente>> PostCliente([FromBody] ClienteDTO clienteDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cliente = new Cliente
            {
                FirstName = clienteDTO.FirstName,
                LastName = clienteDTO.LastName,
                Cpf = clienteDTO.Cpf,
                DataNascimento = clienteDTO.DataNascimento,
                Email = clienteDTO.Email,
                Telefone = clienteDTO.Telefone
            };

            await _clienteRepository.AddClienteAsync(cliente);
            return CreatedAtAction(nameof(GetCliente), new { id = cliente.Id }, cliente);
        }

        // PUT: api/clientes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCliente(int id, [FromBody] ClienteDTO clienteDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cliente = await _clienteRepository.GetClienteAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }

            try
            {
                cliente.FirstName = clienteDTO.FirstName;
                cliente.LastName = clienteDTO.LastName;
                cliente.Cpf = clienteDTO.Cpf;
                cliente.DataNascimento = clienteDTO.DataNascimento;
                cliente.Email = clienteDTO.Email;
                cliente.Telefone = clienteDTO.Telefone;

                await _clienteRepository.UpdateClienteAsync(cliente);
            }
            catch (DbUpdateConcurrencyException)
            {
                // Log the exception
                // Return a proper response, e.g., StatusCode(StatusCodes.Status409Conflict)
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
