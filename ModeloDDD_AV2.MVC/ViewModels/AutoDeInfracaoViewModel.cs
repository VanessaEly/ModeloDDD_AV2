using System.ComponentModel.DataAnnotations;

namespace ModeloDDD_AV2.MVC.ViewModels
{
    public class AutoDeInfracaoViewModel
    {
        [Key]
        public int AutoDeInfracaoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Gravidade.")]
        public int Gravidade { get; set; }

        [Required(ErrorMessage = "Preencha o campo Atenuante.")]
        public bool Atenuante { get; set; }

        [Required(ErrorMessage = "Preencha o campo Agravante.")]
        public bool Agravante { get; set; }

        [Required(ErrorMessage = "Preencha o campo Multa.")]
        public decimal Multa { get; set; }

        public int ProcessoId { get; set; }
        public virtual ProcessoViewModel Processo { get; set; }
    }
}