using Cooperchip.ITDeveloper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Mvc.ViewModels
{
    public class CarrinhoViewModels
    {
        public IList<Produto> Produtos { get; set; }

        [Required]
        [Range(50, 4000, ErrorMessage = "O campo {0} deve estar {1} e {2} reais")]
        public decimal TotalCarrinho { get; set; }

        [Required]
        [StringLength(80, ErrorMessage = "O campo {0} deve ter entre {2} e {1} " +
            "caracteres.", MinimumLength = 4)]
        public string Mensagem { get; set; }
    }
}
