using System;
using System.ComponentModel;

namespace ModeloDDD_AV2.Domain.Entities
{
    public class AutoDeInfracao
    {
        public int AutoDeInfracaoId { get; set; }
        [DisplayName("Gravidade da Infração*")]
        public int Gravidade { get; set; }
        [DisplayName("Atenuante**")]
        public bool Atenuante { get; set; }
        [DisplayName("Agravante*")]
        public bool Agravante { get; set; }
        public decimal Multa { get; set; }

        [DisplayName("Processo*")]
        public int ProcessoId { get; set; }
        public virtual Processo Processo { get; set; }
    }
}
