using System;
using System.Collections.Generic;

namespace ModeloDDD_AV2.Domain.Entities
{
    public class Fornecedor
    {
        public int FornecedorId { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string InscricaoMunicipal { get; set; }
        public decimal ReceitaBruta { get; set; }

        public virtual ICollection<Processo> Processos { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }
    }
}
