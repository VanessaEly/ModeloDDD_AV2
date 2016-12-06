using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModeloDDD_AV2.MVC.ViewModels
{
    public class FornecedorViewModel
    {

        [Key]
        public int FornecedorId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Cnpj.")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "Preencha o campo Razao Social.")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "Preencha o campo Inscrição Municipal.")]
        public string InscricaoMunicipal { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Preencha um Valor para a Receita Bruta.")]
        public decimal ReceitaBruta { get; set; }


        public virtual IEnumerable<ProcessoViewModel> Processos { get; set; }
        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }
        public virtual IEnumerable<EnderecoViewModel> Enderecos { get; set; }
    }
}