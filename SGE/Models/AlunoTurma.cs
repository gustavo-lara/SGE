using System.ComponentModel.DataAnnotations;

namespace SGE.Models
{
    public class AlunoTurma
    {
        public Guid AlunoTurmaId { get; set; }
        public Guid AlunoId { get; set; }
        [Required(ErrorMessage = "O campo Aluno é obrigatório")]
        [MinLength(3, ErrorMessage = "O campo Nome deve ter no " +
                    "mínimo 3 caracteres")]
        [StringLength(100, ErrorMessage = "O campo Nome deve ter no " +
         "máximo 100 caracteres")]
        [Display(Name = "Nome do Aluno(a)")]
        public Aluno? Aluno { get; set; }
        public Guid TurmaId { get; set; }
        [Required(ErrorMessage = "O campo Turma é obrigatório")]
        [MinLength(3, ErrorMessage = "O campo Nome deve ter no " +
                    "mínimo 3 caracteres")]
        [StringLength(100, ErrorMessage = "O campo Nome deve ter no " +
         "máximo 100 caracteres")]
        [Display(Name = "Turma")]
        public Turma? Turma { get; set; }

    }
}
