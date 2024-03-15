using System.ComponentModel.DataAnnotations;

namespace SGE.Models
{
    public class Usuario
    {

        public Guid UsuarioId { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [MinLength(3, ErrorMessage = "O campo Nome deve ter no " +
               "mínimo 3 caracteres")]
        [StringLength(100, ErrorMessage = "O campo Nome deve ter no " +
    "máximo 100 caracteres")]
        [Display(Name = "Nome do Aluno(a)")]
        public string UsuarioNome { get; set; }
        [Required(ErrorMessage = "O campo Email é obrigatório")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Senha")]
        [Required(ErrorMessage = "O campo Senha é obrigatório")]
        public string Senha { get; set; }
        [Display(Name = "Celular")]
        [Required(ErrorMessage = "O campo Celular é obrigatório")]
        public string Celular { get; set; }
        public bool CadAtivo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? CadInativo { get; set; }
        public Guid TipoUsuarioId { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Tipo de Usuario")]

        public TipoUsuario? TipoUsuario { get; set; }
    }
}
