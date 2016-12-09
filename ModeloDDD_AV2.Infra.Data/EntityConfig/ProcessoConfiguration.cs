using ModeloDDD_AV2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDDD_AV2.Infra.Data.EntityConfig
{
    public class ProcessoConfiguration : EntityTypeConfiguration<Processo>
    {
        public ProcessoConfiguration()
        {
            HasKey(p => p.ProcessoId);

            Property(p => p.RelatoFiscalizacao).IsRequired();

            Property(p => p.DataRelato).IsRequired();

            Property(p => p.FiscalResponsavel).IsRequired();

            HasRequired(p => p.Fornecedor).WithMany().HasForeignKey(p => p.FornecedorId);

        }
    }
}
