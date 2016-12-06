using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModeloDDD_AV2.MVC.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public int EnderecoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Logradouro.")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Preencha o campo Numero.")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Preencha o campo Complemento.")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Preencha o campo Bairro.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Preencha o campo Municipio.")]
        public string Municipio { get; set; }

        [Required(ErrorMessage = "Preencha o campo Cep.")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Preencha o campo Uf.")]
        public string Uf { get; set; }

        public int FornecedorId { get; set; }
        public virtual FornecedorViewModel Fornecedor { get; set; }
    }
}