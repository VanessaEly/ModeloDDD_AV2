using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModeloDDD_AV2.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome.")]
        [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres.")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres.")]
        public string Nome { get; set; }
    
        [Required(ErrorMessage = "Preencha a marca para o Produto.")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "Preencha o estoque do Produto.")]
        public string Estoque { get; set; }

        public int FornecedorId { get; set; }
        public virtual FornecedorViewModel Fornecedor { get; set; }
    }
}