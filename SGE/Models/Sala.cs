using System.ComponentModel.DataAnnotations;

namespace SGE.Models
{
    public class Sala
    {
        public Guid SalaId { get; set; }
        [Required(ErrorMessage = "O campo Nome da Sala é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo Sala deve ter no " +
            "máximo 100 caracteres")]
        [Display(Name = "Nome do Sala")]
        public string SalaNome { get; set; }
        public bool CadAtivo { get; set; }
        public DateTime? CadInativo { get; set; }
        public IEnumerable<ReservaSala>? Reservas { get; set; }
    }
}
