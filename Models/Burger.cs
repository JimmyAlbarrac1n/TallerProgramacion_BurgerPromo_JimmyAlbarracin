﻿using System.ComponentModel.DataAnnotations;

namespace TallerProgramacion.Models
{
    public class Burger
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }

        public bool WithCheese { get; set; }
        [Range(0.01, 9999.99)]
        public decimal Precio { get; set; }
        public List<Promo>? Promo { get; set; }
    }
}
