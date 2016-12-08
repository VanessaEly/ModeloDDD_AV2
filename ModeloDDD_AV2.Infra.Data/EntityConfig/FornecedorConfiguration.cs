using ModeloDDD_AV2.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ModeloDDD_AV2.Infra.Data.EntityConfig
{
    public class FornecedorConfiguration : EntityTypeConfiguration<Fornecedor>
    {

        public FornecedorConfiguration()
        {
            HasKey(p => p.FornecedorId);

            Property(p => p.Cnpj).IsRequired();

            Property(p => p.RazaoSocial).IsRequired();

            Property(p => p.InscricaoMunicipal).IsRequired();

            Property(p => p.ReceitaBruta).IsRequired();

        }
    }
}
