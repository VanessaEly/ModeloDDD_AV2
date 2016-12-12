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

        public AutoDeInfracao(){}

        public decimal CalculoMulta(AutoDeInfracao autoDeInfracao, Fornecedor fornecedor)
        {
            const decimal PB = 500m;
            const decimal UFIR = 3.00m;
            decimal Ag;
            decimal At;

            if (autoDeInfracao.Agravante == true)
            {

                Ag = 1;
            }
            else
            {
                Ag = 0;
            }

            if (autoDeInfracao.Atenuante == true)
            {
                At = 0.33m;
            }
            else
            {
                At = 1m;
            }

            autoDeInfracao.Multa = (PB + (((fornecedor.ReceitaBruta - 120000m) * 0.10m) + 120000m) * (UFIR * (Ag + At) * autoDeInfracao.Gravidade));

            return autoDeInfracao.Multa;

        }
    }
}
