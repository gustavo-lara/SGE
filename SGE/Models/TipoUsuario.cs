using System.ComponentModel.DataAnnotations;

namespace SGE.Models
{
    public class TipoUsuario
    {
        public Guid TipoUsuarioId { get; set; }
        [Display(Name = "Tipo de Usuario")]
        [Required(ErrorMessage = "O campo Tipo de Usuario é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo Usuario deve ter no " +
            "máximo 100 caracteres")]
        public string Tipo { get; set; }
        public IEnumerable<Aluno>? Alunos { get; set; }
    }
}
