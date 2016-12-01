
namespace ModeloDDD_AV2.Domain.Entities
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Cep { get; set; }
        public string Uf { get; set; }

        public int FornecedorId { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }  
    }
}
