using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SidekickRegistry.Models
{
    public class Sidekick
    {
        [Key]
        public int SidekickId { get; set; }

        [Required]
        public required string Alias { get; set; }

        public required string SpecialPower { get; set; }

        public int YearsActive { get; set; }

        // Foreign Key
        public int SuperheroId { get; set; }

        // Navigation Property
        [ForeignKey("SuperheroId")]
        public required Superhero Superhero { get; set; }
    }
}
