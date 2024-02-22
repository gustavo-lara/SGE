using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace SGE.Models
{
    public class Aluno
    {
        public Guid AlunoId { get; set; }

        [Required (ErrorMessage = "O Campo Matrícula é obrigatório")]
        [Display(Name ="Matrícula")]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "O Campo Nome é obrigatório")]
        [MinLength(3, ErrorMessage = "O Campo Nome deve ter no mínimo 2 caractéres")]
        [StringLength(130, ErrorMessage = "O Campo Nome deve ter no máximo 130 caractéres")]
        [Display(Name = "Nome do(a) Aluno(a)")]
        public string AlunoNome { get; set; }

        [Required(ErrorMessage = "O Campo Email é obrigatório")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Campo Celular é obrigatório")]
        public string Celular { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool CadAtivo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? CadInativo { get; set; }
        public Guid TipoUsuarioId { get; set; }
        public TipoUsuario? TipoUsuario { get; set; }
        public string? UrlFoto { get; set; }
        public ICollection<AlunoTurma>? AlunoTurmas { get; set; }
    }
}
