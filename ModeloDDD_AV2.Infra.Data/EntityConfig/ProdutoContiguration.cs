using ModeloDDD_AV2.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ModeloDDD_AV2.Infra.Data.EntityConfig
{
    class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        
        public ProdutoConfiguration()
        {
            HasKey(p => p.ProdutoId);

            Property(p => p.Nome).IsRequired().HasMaxLength(250);

            Property(p => p.Marca).IsRequired();

            Property(p => p.Estoque).IsRequired();

            HasRequired(p => p.Fornecedor).WithMany().HasForeignKey(p => p.FornecedorId);

        }
    }
}
