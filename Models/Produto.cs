using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// Classe que referencia o produto ou serviço vinculado ao protocolo
namespace API_CRM.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; } // Identificador único do produto

        public string Nome { get; set; } // Nome ou título do produto

        public string Descricao { get; set; } // Descrição do produto

        public decimal Preco { get; set; } // Preço do produto

        public string Categoria { get; set; } // Categoria ou tipo de produto

        public string Fabricante { get; set; } // Fabricante do produto

        public string NumeroSerie { get; set; } // Número de série (se aplicável)

        public int Estoque { get; set; } // Quantidade disponível em estoque

        public DateTime DataCadastro { get; set; } // Data de cadastro do produto
    }
}
