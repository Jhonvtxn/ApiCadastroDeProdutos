using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProduto.Models
{
    public class Provider
    {
        [Key]
        public new int IdFornecedor { get; set; }

        public string NomeFornecedor { get; set; }

        public int CNPJfornecedor { get; set; }
    }
}
