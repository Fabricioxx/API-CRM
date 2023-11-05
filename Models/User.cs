using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// Usuario que loga no sitema para cunsultar e registrar protocolos
namespace API_CRM.Models
{
    public class User
    {
        public int UserId { get; set; } // Identificador único do usuário

        public string UserName { get; set; } // Nome de usuário

        public string FirstName { get; set; } // Primeiro nome do usuário

        public string LastName { get; set; } // Sobrenome do usuário

        public string Email { get; set; } // Endereço de e-mail do usuário

        public string Password { get; set; } // Senha do usuário (geralmente armazenada com segurança)

        public List<string> Roles { get; set; } // Funções ou papéis do usuário (por exemplo, "Administrador", "Usuário", etc.)

        public DateTime DateOfBirth { get; set; } // Data de nascimento do usuário

        public DateTime RegistrationDate { get; set; } // Data de registro do usuário no sistema

        // Outros atributos relevantes, como número de telefone, endereço, etc.
    }
}
