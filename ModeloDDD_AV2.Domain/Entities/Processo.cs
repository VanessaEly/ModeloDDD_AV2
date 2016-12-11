using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ModeloDDD_AV2.Domain.Entities
{
    public class Processo
    {
        public int ProcessoId { get;  set; }
        [DisplayName("Relato de Fiscalização*")]
        public string RelatoFiscalizacao { get; set; }
        [DisplayName("Data do Relato*")]
        public DateTime DataRelato { get; set; }
        [DisplayName("Fiscal Responsável*")]
        public string FiscalResponsavel { get; set; }

        public int FornecedorId { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }

        public virtual ICollection<AutoDeInfracao> AutosDeInfracao { get; set; }
    }
}
