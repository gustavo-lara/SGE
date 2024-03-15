using System.ComponentModel.DataAnnotations;

namespace SGE.Models
{
    public class Ocorrencia
    {
        public Guid OcorrenciaId { get; set; }
        [Display(Name = "Tipo de Ocorrencia")]
        public Guid TipoOcorrenciaId { get; set; }
        [Display(Name = "Tipo de Ocorrencia")]
        [Required(ErrorMessage = "O campo Tipo de Ocorrencia é obrigatório")]
        public TipoOcorrencia? TipoOcorrencia { get; set; }
        public Guid UsuarioId { get; set; }
        [Display(Name = "Nome do Usuario(a)")]
        [Required(ErrorMessage = "O Nome é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo Usuario deve ter no " +
            "máximo 100 caracteres")]
        public Usuario? Usuario { get; set; }
        public Guid AlunoId { get; set; }
        [Display(Name = "Nome do Aluno(a)")]
        [Required(ErrorMessage = "O campo aluno é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo Nome deve ter no " +
            "máximo 100 caracteres")]
        public Aluno? Aluno { get; set; }

        [Display(Name = "Data da Ocorrenciq")]
        public DateTime DataOcorrencia { get; set; }
        public string Descricao { get; set; }
        public bool CadAtivo { get; set; }
        public DateTime? CadInativo { get; set; }
        public bool Finalizado { get; set; }
        public DateTime? DataFinalizado { get; set; }
        [Required(ErrorMessage = "O campo Tratativa é obrigatório")]

        public string? Tratativa { get; set; }


    }
}
