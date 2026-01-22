using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SidekickRegistry.Models
{
    public class Superhero
    {
        [Key]
        public int SuperheroId { get; set; }

        [Required]
        public required string Alias { get; set; }

        public required string RealName { get; set; }

        public required string OriginStory { get; set; }

        // Navigation Property
        public required ICollection<Sidekick> Sidekicks { get; set; }
    }
 
    }
