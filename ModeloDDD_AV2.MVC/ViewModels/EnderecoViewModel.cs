using System.ComponentModel.DataAnnotations;

namespace ModeloDDD_AV2.MVC.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public int EnderecoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Logradouro.")]
        [MaxLength(200, ErrorMessage = "Máximo de {0} caracteres.")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Preencha o campo Numero.")]
        [MaxLength(50, ErrorMessage = "Máximo de {0} caracteres.")]
        public string Numero { get; set; }


        [Required(ErrorMessage = "Preencha o campo Complemento.")]
        [MaxLength(50, ErrorMessage = "Máximo de {0} caracteres.")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Preencha o campo Bairro.")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres.")]
        public string Bairro { get; set; }


        [Required(ErrorMessage = "Preencha o campo Municipio.")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres.")]
        public string Municipio { get; set; }

        [Required(ErrorMessage = "Preencha o campo CEP.")]
        [MinLength(9, ErrorMessage = "Mínimo de {0} caracteres.")]
        [MaxLength(9, ErrorMessage = "Máximo de {0} caracteres.")]
        [RegularExpression(@"(^(\d{5}-\d{3})|(\d{8})$)", ErrorMessage = "O CEP deverá estar no formato 00000-000")]
        public string Cep { get; set; }

        //Deverá ser uma combox contendo as siglas dos estados Brasileiros. Poderá ser feito com um ENUM ou uma Tabela no banco de dados
        [Required(ErrorMessage = "Preencha o campo Uf.")]
        [MaxLength(2, ErrorMessage = "Máximo de {0} caracteres. Exemplo: RJ para Rio de Janeiro, SP para São Paulo...")]
        public string Uf { get; set; }

        public int FornecedorId { get; set; }
        public virtual FornecedorViewModel Fornecedor { get; set; }
    }
}