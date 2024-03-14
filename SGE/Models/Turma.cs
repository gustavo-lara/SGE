using System.ComponentModel.DataAnnotations;

namespace SGE.Models
{
    public class Turma
    {
        public Guid TurmaId { get; set; }
        [Display(Name = "Nome da Turma")]
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo Nome deve ter no " +
            "máximo 100 caracteres")]
        public string TurmaNome { get; set; }
        [Display(Name = "Turno da Aula")]
        [Required(ErrorMessage = "O campo Turno é obrigatório")]
        public string Turno { get; set; }
        [Display(Name = "Série")]
        [Required(ErrorMessage = "O campo Série é obrigatório")]
        public string Serie { get; set; }
        public bool CadAtivo { get; set; }
        public DateTime? CadInativo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public bool TurmaEncerrada { get; set; }
        public ICollection<AlunoTurma>? AlunoTurmas { get; set; }
    }
}
