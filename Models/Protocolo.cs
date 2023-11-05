using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// Registro feito pelo user com o que ocorreu na ligação 
namespace API_CRM.Models
{
    public class Protocolo
    {
        
      public int ProtocoloId { get; set; }

      public DateTime DataCriacao { get; set; }

      public string Descricao { get; set; }

      public string TipoProtocolo { get; set; } //por exemplo, suporte técnico, vendas, reclamação, etc.).

      public string Status { get; set; } // aberto, fechado, em andamento,

      public string Prioridade { get; set; } // Normal ou Critico

     public string Responsavel { get; set; } // pessoa que abril

     public string Observacoes { get; set; } //

     public Cliente ClienteAssociado { get; set; }

     // Lista de protocolos associados a este protocolo
    public List<Protocolo> ProtocolosAssociados { get; set; }


    }
}