using System;

namespace ModeloDDD_AV2.Domain.Entities
{
    public class AutoDeInfracao
    {
        public int AutoDeInfracaoId { get; set; }
        public int Gravidade { get; set; }
        public bool Atenuante { get; set; }
        public bool Agravante { get; set; }
        public Decimal Multa { get; set; }

        public int ProcessoId { get; set; }
        public virtual Processo Processo { get; set; }
    }
}
