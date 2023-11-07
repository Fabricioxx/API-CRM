
using System.ComponentModel.DataAnnotations;


// Cliente que entra em contato com o SAC 
namespace API_CRM.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string Cpf { get; set; }

        public DateTime DataNascimento { get; set; }

        public string? Email { get; set; }

        public int Telefone { get; set; }


        [Timestamp]
        public byte[]? RowVersion { get; set; }

        // Propriedade para armazenar a lista de protocolos associados a este cliente
        public List<Protocolo>? Protocolos { get; set; }
    }
}
