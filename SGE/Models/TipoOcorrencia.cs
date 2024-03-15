using System.ComponentModel.DataAnnotations;

namespace SGE.Models
{
    public class TipoOcorrencia
    {
        public Guid TipoOcorrenciaId { get; set; }
        [Display(Name = "Nome da Ocorrencia")]
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo Nome deve ter no " +
            "máximo 100 caracteres")]
        public string TipoOcorrenciaNome { get; set; }
        public bool CadAtivo { get; set; }
        public DateTime? CadInativo { get; set; }
    }
}
