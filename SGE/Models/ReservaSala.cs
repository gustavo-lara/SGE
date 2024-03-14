using System.ComponentModel.DataAnnotations;

namespace SGE.Models
{
    public class ReservaSala
    {
        public Guid ReservaSalaId { get; set; }
        public Guid SalaId { get; set; }
        [Display(Name = "Nome da Sala")]
        [Required(ErrorMessage = "O campo Sala é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo Sala deve ter no " +
       "máximo 100 caracteres")]
        public Sala? Sala { get; set; }

        public Guid UsuarioId { get; set; }
        [Display(Name = "Nome do Usuarip(a)")]
        [Required(ErrorMessage = "O campo usuario é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo Nome deve ter no " +
       "máximo 100 caracteres")]
        public Usuario? Usuario { get; set; }
        public DateOnly DataReserva { get; set; }
        public DateOnly DataFimReserva { get; set; }
        public TimeOnly HoraInicio { get; set; }
        public TimeOnly HoraFim { get; set; }
        public bool CadAtivo { get; set; }
        public DateTime? CadInativo { get; set; }
        public string? CorReserva { get; set; }
    }
}
