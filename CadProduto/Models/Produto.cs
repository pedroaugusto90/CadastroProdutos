using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Linq;
using System.Web;

namespace CadProduto.Models
{
    public class Produto
    {
        [Required(ErrorMessage = "Insira o código!")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "Preencha o nome do produto!")]
        public string Nome { get; set; }
        
        [Required]
        public string Descricao { get; set; }

        [RegularExpression(@"^[0-9]+(\.[0-9]{1,2})$", ErrorMessage = "Valor inválido!")]
        public string Peso { get; set; }
        
        [Required(ErrorMessage = "Por favor, insira a categoria do produto!")]
        public string Categoria { get; set; }
        
        [RegularExpression(@"^[0-9]+(\.[0-9]{1,2})$",ErrorMessage = "Preço único inválido!")]
        public string precoUnico { get; set; }
    }
}