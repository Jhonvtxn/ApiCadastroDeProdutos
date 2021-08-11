using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProduto.Models
{
    public class Product
    {
        [Key]
        public new int Id { get; set; }

        public string Nome { get; set; }

        public string Marca { get; set; }

        public int Valor { get; set; }

        [ForeignKey("Provider")]
        public int FornecedorId { get; set; }

        public Provider Provider { get; set; }
    }
}
