using System.ComponentModel.DataAnnotations;

namespace TallerProgramacion.Models
{
    public class Promo
    {
        [Key]
        public int PromoID { get; set; }
        [Required]
        public string? Descripcion { get; set; }
        [Required]
        public DateTime FechaPromo { get; set; }

        public int BurgerID { get; set; }
        public Burger? Burger { get; set; }
    }
}
