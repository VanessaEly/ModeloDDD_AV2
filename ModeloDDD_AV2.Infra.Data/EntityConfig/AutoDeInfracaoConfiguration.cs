using ModeloDDD_AV2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDDD_AV2.Infra.Data.EntityConfig
{
    public class AutoDeInfracaoConfiguration : EntityTypeConfiguration<AutoDeInfracao>
    {

        public AutoDeInfracaoConfiguration()
        {
            HasKey(p => p.AutoDeInfracaoId);

            Property(p => p.Gravidade).IsRequired();

            Property(p => p.Atenuante).IsRequired();

            Property(p => p.Agravante).IsRequired();

            Property(p => p.Multa).IsRequired();

            HasRequired(p => p.Processo).WithMany().HasForeignKey(p => p.ProcessoId);

        }
    }
}
