using ModeloDDD_AV2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDDD_AV2.Infra.Data.EntityConfig
{
    public class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {

        public EnderecoConfiguration()
        {
            HasKey(p => p.EnderecoId);

            Property(p => p.Logradouro).IsRequired();

            Property(p => p.Numero).IsRequired();

            Property(p => p.Complemento).IsRequired();

            Property(p => p.Bairro).IsRequired();

            Property(p => p.Municipio).IsRequired();

            Property(p => p.Cep).IsRequired();

            Property(p => p.Uf).IsRequired();

            HasRequired(p => p.Fornecedor).WithMany().HasForeignKey(p => p.FornecedorId);

        }
    }
}
