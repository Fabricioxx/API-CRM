using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// Uma classe que representa os dados de um cliente para serem enviados pela API-CRM.
namespace API_CRM.DTO
{
    public class ClienteDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Cpf { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Email { get; set; }

        public int Telefone { get; set; }
    }
}
