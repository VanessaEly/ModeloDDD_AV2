using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloDDD_AV2.Domain.Entities
{
    public class Processo
    {
        public int ProcessoId { get;  set; }
        public string RelatoFiscalizacao { get; set; }
        public DateTime DataRelato { get; set; }
        public string FiscalResponsavel { get; set; }

        public int FornecedorId { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }

        public virtual IEnumerable<AutoDeInfracao> AutosDeInfracao { get; set; }
    }
}
