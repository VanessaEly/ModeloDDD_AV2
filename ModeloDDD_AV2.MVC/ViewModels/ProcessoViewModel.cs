using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModeloDDD_AV2.MVC.ViewModels
{
    public class ProcessoViewModel
    {

        [Key]
        public int ProcessoId { get; set; }

        [Required(ErrorMessage = "Preencha um Valor para a Data de Relato.")]
        [ScaffoldColumn(false)]
        public DateTime DataRelato { get; set; }

        [Required(ErrorMessage = "Preencha o relato de fiscalização.")]
        public string RelatoFiscalizacao { get; set; }

        [Required(ErrorMessage = "Preencha o fiscal responsável.")]
        public string FiscalResponsavel { get; set; }


        public int FornecedorId { get; set; }

        public virtual FornecedorViewModel Fornecedor { get; set; }
        public virtual IEnumerable<AutoDeInfracaoViewModel> AutosDeInfracao { get; set; }

    }
}