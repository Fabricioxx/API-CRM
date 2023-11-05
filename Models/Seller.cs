using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// Lojas pareceiras que vendem no Site
namespace API_CRM.Models
{
    public class Seller
    {
        public int SellerId { get; set; } // Identificador único do vendedor

        public string Name { get; set; } // Nome ou nome da loja

        public string Description { get; set; } // Descrição da loja ou vendedor

        public string ContactEmail { get; set; } // Endereço de e-mail de contato da loja

        public string Phone { get; set; } // Número de telefone da loja

        public string Website { get; set; } // URL do site da loja

        public string Address { get; set; } // Endereço da loja

        // Outros atributos relevantes, como avaliações, produtos oferecidos, etc.
    }
}
